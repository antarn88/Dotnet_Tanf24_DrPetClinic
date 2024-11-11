using DrPetClinic.Bll.DTOs;
using DrPetClinic.Bll.Helpers;
using DrPetClinic.Bll.Interfaces;
using DrPetClinic.Bll.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DrPetClinic.Web.Pages.DoctorDetails
{
    public class IndexModel : PageModel
    {
        private readonly IConsultationTimeService _consultationTimeService;
        private readonly IEmployeeService _employeeService;

        public IndexModel(IConsultationTimeService consultationTimeService, IEmployeeService employeeService)
        {
            _consultationTimeService = consultationTimeService;
            _employeeService = employeeService;
        }

        public List<ConsultationTimeDto> ConsultationTimes { get; set; } = new();
        public string DoctorName { get; set; } = string.Empty;

        public async Task OnGetAsync(Guid orvosId)
        {
            var doctor = await _employeeService.GetEmployeeByIdAsync(orvosId);

            DoctorName = doctor.Name;
            ConsultationTimes = await _consultationTimeService.GetConsultationTimesForNextThreeMonthsAsync(orvosId);
        }

        public string GetHungarianMonthName(int month) => DateHelper.GetHungarianMonthName(month);
        public string GetHungarianDayOfWeek(DayOfWeek day) => DateHelper.GetHungarianDayOfWeek(day);
    }
}
