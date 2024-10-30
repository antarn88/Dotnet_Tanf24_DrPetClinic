using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DrPetClinic.Data;
using DrPetClinic.Data.Entities;

namespace DrPetClinic.Web.Pages.Entries
{
    public class DeleteModel : PageModel
    {
        private readonly DrPetClinic.Data.DrPetClinicDBContext _context;

        public DeleteModel(DrPetClinic.Data.DrPetClinicDBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Entry Entry { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entry = await _context.Entries.FirstOrDefaultAsync(m => m.Id == id);

            if (entry == null)
            {
                return NotFound();
            }
            else
            {
                Entry = entry;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entry = await _context.Entries.FindAsync(id);
            if (entry != null)
            {
                Entry = entry;
                _context.Entries.Remove(Entry);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
