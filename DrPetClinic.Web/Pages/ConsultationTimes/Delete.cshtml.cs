using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DrPetClinic.Data;
using DrPetClinic.Data.Entities;

namespace DrPetClinic.Web.Pages.ConsultationTimes
{
    public class DeleteModel : PageModel
    {
        private readonly DrPetClinic.Data.DrPetClinicDBContext _context;

        public DeleteModel(DrPetClinic.Data.DrPetClinicDBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ConsultationTime ConsultationTime { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consultationtime = await _context.ConsultationTimes.FirstOrDefaultAsync(m => m.Id == id);

            if (consultationtime == null)
            {
                return NotFound();
            }
            else
            {
                ConsultationTime = consultationtime;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consultationtime = await _context.ConsultationTimes.FindAsync(id);
            if (consultationtime != null)
            {
                ConsultationTime = consultationtime;
                _context.ConsultationTimes.Remove(ConsultationTime);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
