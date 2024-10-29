using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DrPetClinic.Data.Entities
{
    public class Animal : IEntityTypeConfiguration<Animal>
    {
        public Guid Id { get; set; }
        public string Species { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public string? Description { get; set; }
        public ICollection<Person> Owners { get; set; } = new List<Person>();

        public void Configure(EntityTypeBuilder<Animal> builder)
        {

        }
    }
}
