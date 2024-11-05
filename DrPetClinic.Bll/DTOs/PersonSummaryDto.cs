namespace DrPetClinic.Bll.DTOs
{
    public class PersonSummaryDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Residence { get; set; }
        public string? Description { get; set; }
    }
}
