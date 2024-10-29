using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DrPetClinic.Data.Entities
{
    public class ConsultationTime : IEntityTypeConfiguration<ConsultationTime>
    {
        public Guid Id { get; set; }
        public DayOfWeek DayOfWeek { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public bool IsAvailable { get; set; } = true;
        public string? Description { get; set; }

        public Employee Employee { get; set; }
        public Guid EmployeeId { get; set; }

        public void Configure(EntityTypeBuilder<ConsultationTime> builder)
        {
            builder
                .HasOne(x => x.Employee)
                .WithMany(x => x.ConsultationTimes)
                .HasForeignKey(x => x.EmployeeId)
                .HasPrincipalKey(x => x.Id)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
