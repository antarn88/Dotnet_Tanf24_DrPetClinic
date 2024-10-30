using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DrPetClinic.Data.Entities
{
    public class Person : IEntityTypeConfiguration<Person>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Residence { get; set; }
        public string? Description { get; set; }

        public ICollection<Animal> Animals { get; set; } = [];
        public ICollection<Treatment> Treatments { get; set; } = [];
        public void Configure(EntityTypeBuilder<Person> builder) { }
    }
}
