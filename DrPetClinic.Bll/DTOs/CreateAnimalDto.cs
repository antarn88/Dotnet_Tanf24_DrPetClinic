namespace DrPetClinic.Bll.DTOs
{
    public class CreateAnimalDto
    {
        public string Species { get; set; }
        public string Type { get; set; }
        public DateTime BirthDate { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public string? Description { get; set; }
    }
}
