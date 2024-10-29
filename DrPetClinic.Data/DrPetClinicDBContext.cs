using DrPetClinic.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace DrPetClinic.Data
{
    public class DrPetClinicDBContext : DbContext
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
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
