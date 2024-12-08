using DrPetClinic.Bll.Interfaces;
using DrPetClinic.Bll.MappingProfiles;
using DrPetClinic.Bll.Services;
using DrPetClinic.Data;
using DrPetClinic.Data.Entities;
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
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();
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
            builder.Services.AddScoped<IConsultationTimeService, ConsultationTimeService>();
            builder.Services.AddScoped<IAnimalService, AnimalService>();
            builder.Services.AddScoped<IEmployeeService, EmployeeService>();
            builder.Services.AddScoped<IEntryService, EntryService>();
            builder.Services.AddScoped<IPersonService, PersonService>();
            builder.Services.AddScoped<ITreatmentService, TreatmentService>();

            var app = builder.Build();

            var cultureInfo = new System.Globalization.CultureInfo("hu-HU");
            CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
            CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;

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

            app.MapRazorPages();

            app.Run();
        }
    }
}
