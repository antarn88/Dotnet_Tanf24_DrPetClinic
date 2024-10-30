using DrPetClinic.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DrPetClinic.Web.Pages.ConsultationTimes
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
            PopulateViewData();
            return Page();
        }

        [BindProperty]
        public ConsultationTime ConsultationTime { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                PopulateViewData(); // Ha hibás az űrlap, újratölti a legördülő listákat
                return Page();
            }

            // Csak az EmployeeId-t állítjuk be, és az EF Core kezeli a kapcsolatot
            _context.ConsultationTimes.Add(ConsultationTime);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }

        private void PopulateViewData()
        {
            ViewData["EmployeeId"] = new SelectList(_context.Employees, "Id", "Id");

            // DayOfWeek enum értékeinek listája
            ViewData["DayOfWeekList"] = Enum.GetValues(typeof(DayOfWeek))
                .Cast<DayOfWeek>()
                .Select(d => new SelectListItem { Value = ((int)d).ToString(), Text = d.ToString() });
        }
    }
}
