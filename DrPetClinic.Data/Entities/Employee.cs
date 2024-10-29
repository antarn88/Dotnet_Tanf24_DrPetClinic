using DrPetClinic.Data.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DrPetClinic.Data.Entities
{
    public class Employee : IEntityTypeConfiguration<Employee>
    {
        public Guid Id { get; set; }
        public string? Description { get; set; }
        public EmployeeType Type { get; set; }
        public ICollection<ConsultationTime>? ConsultationTimes { get; set; }

        public void Configure(EntityTypeBuilder<Employee> builder)
        {

        }
    }

}
