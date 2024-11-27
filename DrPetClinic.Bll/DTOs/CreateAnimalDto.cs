using System.ComponentModel.DataAnnotations;

namespace DrPetClinic.Bll.DTOs
{
    public class CreateAnimalDto
    {
        // public string Species { get; set; }
        // public string Type { get; set; }
        // public DateTime BirthDate { get; set; }
        // public string Name { get; set; }
        // public string Status { get; set; }
        // public string? Description { get; set; }

        public string Name { get; set; }
        public string Species { get; set; }

        [Required(ErrorMessage = "A típus megadása kötelező.")]
        public string Type { get; set; }

        [Required(ErrorMessage = "A születési dátum megadása kötelező.")]
        [DataType(DataType.Date)]
        [Display(Name = "Születési dátum")]
        public DateTime BirthDate { get; set; }

        public string Status { get; set; }
        public string? Description { get; set; }
        public Guid OwnerId { get; set; }
    }
}
