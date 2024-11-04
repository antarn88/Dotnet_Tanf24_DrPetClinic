namespace DrPetClinic.Bll.DTOs
{
    public class CreateConsultationTimeDto
    {
        public short Year { get; set; }
        public byte Month { get; set; }
        public byte Week { get; set; }
        public DayOfWeek DayOfWeek { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public bool IsAvailable { get; set; } = true;
        public string? Description { get; set; }
        public Guid EmployeeId { get; set; }
    }
}
