using DrPetClinic.Bll.DTOs;
using DrPetClinic.Bll.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DrPetClinic.Web.Pages.Admin.Doctors
{
    public class IndexModel : PageModel
    {
        public IEmployeeService EmployeeService { get; }
        public List<EmployeeDto> Doctors { get; set; }

        public IndexModel(IEmployeeService employeeService)
        {
            EmployeeService = employeeService;
        }

        public async Task OnGetAsync()
        {
            Doctors = await EmployeeService.GetDoctorsAsync();
        }
    }
}
