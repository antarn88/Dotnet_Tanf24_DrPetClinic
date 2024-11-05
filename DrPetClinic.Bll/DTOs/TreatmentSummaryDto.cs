namespace DrPetClinic.Bll.DTOs
{
    public class TreatmentSummaryDto
    {
        public Guid Id { get; set; }
        public string? Description { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
    }
}
