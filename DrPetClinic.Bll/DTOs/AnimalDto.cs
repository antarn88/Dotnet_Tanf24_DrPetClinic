namespace DrPetClinic.Bll.DTOs
{
    public class AnimalDto
    {
        public Guid Id { get; set; }
        public string Species { get; set; }
        public string Type { get; set; }
        public DateTime BirthDate { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public string? Description { get; set; }
        public List<OwnerDto> Owners { get; set; } = [];
        public List<TreatmentSummaryDto> Treatments { get; set; } = [];
        public List<Guid> OwnerIds { get; set; } = [];
    }
}
