using DrPetClinic.Data.Enums;

namespace DrPetClinic.Bll.DTOs
{
    public class EmployeeDetailsDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? ImageFileName { get; set; }
        public EmployeeType Type { get; set; }
        public List<ConsultationTimeDto> ConsultationTimes { get; set; } = [];
        public List<TreatmentSummaryDto> Treatments { get; set; } = [];
    }
}
