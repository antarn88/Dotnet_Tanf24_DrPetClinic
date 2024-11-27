using DrPetClinic.Bll.DTOs;
using DrPetClinic.Bll.Services;
using DrPetClinic.Data.Enums;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DrPetClinic.Web.Pages.Admin.Doctors
{
    public class CreateModel : PageModel
    {
        private readonly IEmployeeService _employeeService;

        [BindProperty]
        public CreateEmployeeDto Doctor { get; set; }

        public CreateModel(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public void OnGet()
        {
            // Inicializálhatod a Doctor változót, ha szükséges.
            Doctor = new CreateEmployeeDto();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Doctor.Type = EmployeeType.Doctor; // Biztosítsd, hogy az új alkalmazott orvos legyen.
            await _employeeService.CreateEmployeeAsync(Doctor);

            return RedirectToPage("/Admin/Doctors/Index"); // Visszairányítás a listaoldalra.
        }
    }
}
