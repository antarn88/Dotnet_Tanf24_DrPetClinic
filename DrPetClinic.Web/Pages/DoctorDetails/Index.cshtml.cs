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

        public Dictionary<string, List<ConsultationTimeDto>> ConsultationTimes { get; set; }
        public string DoctorName { get; set; } = string.Empty;

        public EmployeeDetailsDto Doctor { get; set; }

        public async Task OnGetAsync(Guid orvosId)
        {
            Doctor = await _employeeService.GetEmployeeByIdAsync(orvosId);

            DoctorName = Doctor.Name;
            ConsultationTimes = await _consultationTimeService.GetConsultationTimesForNextThreeMonthsGroupedByWeekAsync(orvosId);
        }

        public string GetHungarianMonthName(int month) => DateHelper.GetHungarianMonthName(month);
        public string GetHungarianDayOfWeek(DayOfWeek day) => DateHelper.GetHungarianDayOfWeek(day);
    }
}
