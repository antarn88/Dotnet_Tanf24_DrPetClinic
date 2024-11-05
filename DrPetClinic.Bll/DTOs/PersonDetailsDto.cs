namespace DrPetClinic.Bll.DTOs
{
    public class PersonDetailsDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Residence { get; set; }
        public string? Description { get; set; }
        public List<AnimalDto> Animals { get; set; } = [];
        public List<TreatmentSummaryDto> Treatments { get; set; } = [];
    }
}
