using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DrPetClinic.Data.Entities
{
    public class Treatment : IEntityTypeConfiguration<Treatment>
    {
        public Guid Id { get; set; }
        public string? Description { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }

        public Guid DoctorId { get; set; }
        public Employee? Doctor { get; set; }

        public Guid AnimalId { get; set; }
        public Animal? Animal { get; set; }

        public Guid PersonId { get; set; }
        public Person? Person { get; set; }

        public ICollection<Entry> Entries { get; set; } = [];

        public void Configure(EntityTypeBuilder<Treatment> builder)
        {
            builder.HasKey(x => x.Id);

            builder
                .Property(x => x.Amount)
                .HasPrecision(18, 0);

            builder
                .HasOne(x => x.Doctor)
                .WithMany(x => x.Treatments)
                .HasForeignKey(x => x.DoctorId)
                .HasPrincipalKey(x => x.Id)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(x => x.Animal)
                .WithMany(x => x.Treatments)
                .HasForeignKey(x => x.AnimalId)
                .HasPrincipalKey(x => x.Id)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(x => x.Person)
                .WithMany(x => x.Treatments)
                .HasForeignKey(x => x.PersonId)
                .HasPrincipalKey(x => x.Id)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
