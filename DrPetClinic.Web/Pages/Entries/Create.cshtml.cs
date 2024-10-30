using DrPetClinic.Data.Entities;
using DrPetClinic.Data.Enums;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DrPetClinic.Web.Pages.Entries
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
            ViewData["HistoryId"] = new SelectList(_context.Entries, "Id", "Id");
            ViewData["TreatmentId"] = new SelectList(_context.Treatments, "Id", "Id");
            ViewData["EntryTypeList"] = Enum.GetValues(typeof(EntryType))
              .Cast<EntryType>()
              .Select(e => new SelectListItem { Value = ((int)e).ToString(), Text = e.ToString() });

            return Page();
        }

        [BindProperty]
        public Entry Entry { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Entries.Add(Entry);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
