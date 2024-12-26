using DrPetClinic.Data.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DrPetClinic.Data.Entities
{
    public class Employee : IdentityUser<Guid>, IEntityTypeConfiguration<Employee>
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? ImageFileName { get; set; }
        public EmployeeType Type { get; set; }

        public ICollection<ConsultationTime>? ConsultationTimes { get; set; } = [];
        public ICollection<Treatment>? Treatments { get; set; } = [];

        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employees");
            builder.HasKey(x => x.Id);
        }
    }

}
