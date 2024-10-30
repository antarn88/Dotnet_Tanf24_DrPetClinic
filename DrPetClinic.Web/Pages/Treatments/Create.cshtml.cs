using DrPetClinic.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DrPetClinic.Web.Pages.Treatments
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
            ViewData["AnimalId"] = new SelectList(_context.Animals, "Id", "Name");
            ViewData["DoctorId"] = new SelectList(_context.Employees, "Id", "Id");
            ViewData["PersonId"] = new SelectList(_context.People, "Id", "Name");
            return Page();
        }

        [BindProperty]
        public Treatment Treatment { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Treatments.Add(Treatment);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
