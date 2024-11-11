using DrPetClinic.Bll.DTOs;
using DrPetClinic.Bll.Interfaces;
using DrPetClinic.Bll.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DrPetClinic.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IConsultationTimeService _consultationTimeService;
        private readonly IEmployeeService _employeeService;




        public Dictionary<string, List<ConsultationTimeDto>> GroupedConsultationTimes { get; private set; } = new();
        public List<EmployeeDto> Doctors { get; set; } = [];


        public IndexModel(ILogger<IndexModel> logger, IConsultationTimeService consultationTimeService, IEmployeeService employeeService)
        {
            _logger = logger;
            _consultationTimeService = consultationTimeService;
            _employeeService = employeeService;
        }

        public async Task OnGetAsync()
        {
            GroupedConsultationTimes = await _consultationTimeService.GetCurrentWeekGroupedConsultationTimesAsync();
            Doctors = await _employeeService.GetDoctorsAsync();
        }
    }
}
