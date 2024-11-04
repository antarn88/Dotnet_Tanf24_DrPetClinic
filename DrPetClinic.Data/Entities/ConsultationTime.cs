using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DrPetClinic.Data.Entities
{
    public class ConsultationTime : IEntityTypeConfiguration<ConsultationTime>
    {
        public Guid Id { get; set; }
        public short Year { get; set; }
        public byte Month { get; set; }
        public byte Week { get; set; }
        public DayOfWeek DayOfWeek { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public bool IsAvailable { get; set; } = true;
        public string? Description { get; set; }

        public Employee? Employee { get; set; }
        public Guid EmployeeId { get; set; }

        public void Configure(EntityTypeBuilder<ConsultationTime> builder)
        {
            builder.HasKey(x => x.Id);

            builder
                .HasOne(x => x.Employee)
                .WithMany(x => x.ConsultationTimes)
                .HasForeignKey(x => x.EmployeeId)
                .HasPrincipalKey(x => x.Id)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(x => x.Year)
                .IsRequired();

            builder.Property(x => x.Month)
                .IsRequired()
                .HasMaxLength(12);

            builder.Property(x => x.Week)
                .IsRequired()
                .HasMaxLength(53);
        }
    }
}
