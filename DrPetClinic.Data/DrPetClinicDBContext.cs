using DrPetClinic.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace DrPetClinic.Data
{
    public class DrPetClinicDBContext : IdentityDbContext<Employee, IdentityRole<Guid>, Guid>
    {
        public DrPetClinicDBContext(DbContextOptions<DrPetClinicDBContext> options) : base(options) { }

        public DbSet<Animal> Animals { get; set; }
        public DbSet<ConsultationTime> ConsultationTimes { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Entry> Entries { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Treatment> Treatments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Az Identity miatt
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Entity<Employee>().HasData(SeedData.GetEmployees());
            modelBuilder.Entity<Animal>().HasData(SeedData.GetAnimals());
            modelBuilder.Entity<Person>().HasData(SeedData.GetPeople());
            modelBuilder.Entity<Treatment>().HasData(SeedData.GetTreatments());
            modelBuilder.Entity<Entry>().HasData(SeedData.GetEntries());
            modelBuilder.Entity<ConsultationTime>().HasData(SeedData.GetConsultationTimes());
            modelBuilder.Entity("AnimalPerson").HasData(SeedData.GetAnimalOwners());
        }

    }
}
