using DrPetClinic.Data.Entities;
using DrPetClinic.Data.Enums;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DrPetClinic.Web.Pages.Employees
{
    public class CreateModel : PageModel
    {
        private readonly DrPetClinic.Data.DrPetClinicDBContext _context;

        public CreateModel(DrPetClinic.Data.DrPetClinicDBContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["EmployeeTypeList"] = Enum.GetValues(typeof(EmployeeType))
                .Cast<EmployeeType>()
                .Select(e => new SelectListItem { Value = ((int)e).ToString(), Text = e.ToString() });

            return Page();
        }

        [BindProperty]
        public Employee Employee { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Employees.Add(Employee);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
