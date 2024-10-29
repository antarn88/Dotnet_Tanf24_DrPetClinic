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
        public Employee Doctor { get; set; }
        public Animal Animal { get; set; }
        public Person Person { get; set; }
        public ICollection<Entry> Entries { get; set; } = new List<Entry>();

        public void Configure(EntityTypeBuilder<Treatment> builder)
        {

        }
    }
}
