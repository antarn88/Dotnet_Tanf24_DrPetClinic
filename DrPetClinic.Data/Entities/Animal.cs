using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DrPetClinic.Data.Entities
{
    public class Animal : IEntityTypeConfiguration<Animal>
    {
        public Guid Id { get; set; }
        public string Species { get; set; }
        public string Type { get; set; }
        public DateTime BirthDate { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public string? Description { get; set; }

        public ICollection<Person> Owners { get; set; } = [];
        public ICollection<Treatment> Treatments { get; set; } = [];

        public void Configure(EntityTypeBuilder<Animal> builder) { }
    }
}
