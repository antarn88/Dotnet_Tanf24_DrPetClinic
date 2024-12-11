using DrPetClinic.Bll.Interfaces;
using DrPetClinic.Bll.MappingProfiles;
using DrPetClinic.Bll.Services;
using DrPetClinic.Data;
using DrPetClinic.Data.Entities;
using DrPetClinic.Data.SeedIdentityData;
using DrPetClinic.Web.Services;
using DrPetClinic.Web.Settings;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System.Globalization;

namespace DrPetClinic.Web
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<DrPetClinicDBContext>(options =>
            {
                options.ConfigureWarnings(warnings => warnings.Ignore(RelationalEventId.PendingModelChangesWarning)); // Enélkül exception-t kaptam migrációkor!
                options.UseSqlServer(builder.Configuration.GetConnectionString("DrPetClinicDB"));
            });

            // Identity
            builder.Services
              .AddIdentity<Employee, IdentityRole<Guid>>()
              .AddEntityFrameworkStores<DrPetClinicDBContext>()
              .AddDefaultTokenProviders();

            // Identity szabályok
            builder.Services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequireDigit = false;
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.User.RequireUniqueEmail = false;
                options.SignIn.RequireConfirmedAccount = true;
            });

            builder.Services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;

                options.LoginPath = "/Identity/Account/Login";
                options.AccessDeniedPath = "/Identity/Account/AccessDenied";
                options.SlidingExpiration = true;
            });

            // MailSettings
            builder.Services.Configure<MailSettings>(builder.Configuration.GetSection("MailSettings"));
            builder.Services.AddTransient<IEmailSender, EmailSender>();

            // Automapperek
            builder.Services.AddAutoMapper(typeof(ConsultationTimeProfile));
            builder.Services.AddAutoMapper(typeof(AnimalProfile));
            builder.Services.AddAutoMapper(typeof(EmployeeProfile));
            builder.Services.AddAutoMapper(typeof(EntryProfile));
            builder.Services.AddAutoMapper(typeof(PersonProfile));
            builder.Services.AddAutoMapper(typeof(TreatmentProfile));

            // Service-ek
            builder.Services.AddScoped<IRoleSeedService, RoleSeedService>();
            builder.Services.AddScoped<IUserSeedService, UserSeedService>();
            builder.Services.AddScoped<IConsultationTimeService, ConsultationTimeService>();
            builder.Services.AddScoped<IAnimalService, AnimalService>();
            builder.Services.AddScoped<IEmployeeService, EmployeeService>();
            builder.Services.AddScoped<IEntryService, EntryService>();
            builder.Services.AddScoped<IPersonService, PersonService>();
            builder.Services.AddScoped<ITreatmentService, TreatmentService>();

            // Google belépéshez
            builder.Services.AddAuthentication().AddGoogle(options =>
            {
                options.ClientId = builder.Configuration.GetSection("Authentication:Google:ClientId").Value!;
                options.ClientSecret = builder.Configuration.GetSection("Authentication:Google:ClientSecret").Value!;
            });

            builder.Services.AddAuthorization(auth =>
            {
                auth.AddPolicy("RequiredAssistantRole", policy => policy.RequireRole("Assistants"));
                auth.AddPolicy("RequiredDoctorRole", policy => policy.RequireRole("Doctors"));
                auth.AddPolicy("RequiredAssistantOrDoctorRole", policy => policy.RequireRole(["Assistants", "Doctors"]));
            });

            builder.Services.AddRazorPages(options =>
            {
                options.Conventions.AuthorizeFolder("/Admin", "RequiredDoctorRole");
                options.Conventions.AuthorizeFolder("/Assistant", "RequiredAssistantOrDoctorRole");
            });

            var app = builder.Build();

            // Nyelvi beállítások
            var cultureInfo = new CultureInfo("hu-HU");
            CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
            CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;

            // Role seedelése
            var roleSeeder = app.Services.CreateScope().ServiceProvider.GetRequiredService<IRoleSeedService>();
            await roleSeeder.SeedRoleAsync();

            // User seedelése
            var userSeeder = app.Services.CreateScope().ServiceProvider.GetRequiredService<IUserSeedService>();
            await userSeeder.SeedUserAsync();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.MapStaticAssets(); // .NET 9 igényli az app.UseStaticFiles() helyett

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            // A UseAuthentication és UseAuthorization után vizsgáljuk és levédjük a register oldalt!
            app.Use(async (context, next) =>
            {
                var path = context.Request.Path;
                if (path.StartsWithSegments("/Identity/Account/Register") && !context.User.IsInRole("Doctors"))
                {
                    if (context.User.Identity != null && context.User.Identity.IsAuthenticated)
                    {
                        // Ha be van jelentkezve, akkor AccessDenied
                        context.Response.Redirect("AccessDenied");
                    }
                    else
                    {
                        // Ha nincs bejelentkezve, irányítás a Login oldalra ReturnUrl paraméterrel
                        var returnUrl = context.Request.Path + context.Request.QueryString;
                        var loginUrl = $"Login?ReturnUrl={Uri.EscapeDataString(returnUrl)}";
                        context.Response.Redirect(loginUrl);
                    }
                    return;
                }

                await next();
            });


            app.MapRazorPages();

            app.Run();
        }
    }
}
