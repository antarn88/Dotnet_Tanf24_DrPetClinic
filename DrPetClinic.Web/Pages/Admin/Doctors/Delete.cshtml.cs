using AutoMapper;
using DrPetClinic.Bll.DTOs;
using DrPetClinic.Bll.Interfaces;
using DrPetClinic.Bll.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DrPetClinic.Web.Pages.Admin.Doctors
{
    public class DeleteModel : PageModel
    {
        private readonly IEmployeeService _employeeService;
        private readonly IMapper _mapper;

        [BindProperty]
        public EmployeeDto Doctor { get; set; }

        public DeleteModel(IEmployeeService employeeService, IMapper mapper)
        {
            _employeeService = employeeService;
            _mapper = mapper;
        }

        public async Task<IActionResult> OnGetAsync(Guid doktorId)
        {
            var doctor = await _employeeService.GetEmployeeByIdAsync(doktorId);
            if (doctor == null)
            {
                return NotFound();
            }

            Doctor = _mapper.Map<EmployeeDto>(doctor);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (Doctor == null || Doctor.Id == Guid.Empty)
            {
                return NotFound();
            }

            try
            {
                await _employeeService.DeleteEmployeeAsync(Doctor.Id);
                return RedirectToPage("/Admin/Doctors/Index");
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }
        }
    }
}
