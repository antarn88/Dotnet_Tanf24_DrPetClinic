using DrPetClinic.Bll.DTOs;

namespace DrPetClinic.Web.ViewModels;

public class MonthlyConsultationViewModel
{
    public string DoctorName { get; set; } = string.Empty;
    public Dictionary<string, List<ConsultationTimeDto>> ConsultationTimes { get; set; } = new();
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public Guid DoctorId { get; set; }
}
