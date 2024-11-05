namespace DrPetClinic.Bll.DTOs
{
    public class TreatmentDetailsDto
    {
        public Guid Id { get; set; }
        public string? Description { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public EmployeeDto Doctor { get; set; }
        public AnimalDto Animal { get; set; }
        public PersonSummaryDto Person { get; set; }
        public List<EntrySummaryDto> Entries { get; set; } = [];
    }
}
