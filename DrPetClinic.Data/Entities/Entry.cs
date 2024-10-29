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
        public Guid? History { get; set; }

        public void Configure(EntityTypeBuilder<Entry> builder)
        {

        }
    }
}
