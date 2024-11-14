using DrPetClinic.Bll.Interfaces;
using DrPetClinic.Bll.MappingProfiles;
using DrPetClinic.Bll.Services;
using DrPetClinic.Data;
using Microsoft.EntityFrameworkCore;
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
            builder.Services.AddDbContext<DrPetClinicDBContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DrPetClinicDB")));

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
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}
