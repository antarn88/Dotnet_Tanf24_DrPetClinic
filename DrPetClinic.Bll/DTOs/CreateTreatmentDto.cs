namespace DrPetClinic.Bll.DTOs
{
    public class CreateTreatmentDto
    {
        public string? Description { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public Guid DoctorId { get; set; }
        public Guid AnimalId { get; set; }
        public Guid PersonId { get; set; }
    }
}
