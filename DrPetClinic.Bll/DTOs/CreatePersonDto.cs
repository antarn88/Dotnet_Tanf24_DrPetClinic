namespace DrPetClinic.Bll.DTOs
{
    public class CreatePersonDto
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Residence { get; set; }
        public string? Description { get; set; }
    }
}
