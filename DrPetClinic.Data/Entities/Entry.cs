using DrPetClinic.Data.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DrPetClinic.Data.Entities
{
    public class Entry : IEntityTypeConfiguration<Entry>
    {
        public Guid Id { get; set; }
        public string? Description { get; set; }
        public EntryType Type { get; set; }
        public string? Medicine { get; set; }
        public int? Length { get; set; }

        public Guid? HistoryId { get; set; }
        public Entry? History { get; set; }

        public Treatment Treatment { get; set; }
        public Guid TreatmentId { get; set; }

        public void Configure(EntityTypeBuilder<Entry> builder)
        {
            builder
              .HasOne(x => x.History)
              .WithMany()
              .HasForeignKey(x => x.HistoryId)
              .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(x => x.Treatment)
                .WithMany(x => x.Entries)
                .HasForeignKey(x => x.TreatmentId)
                .HasPrincipalKey(x => x.Id)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
