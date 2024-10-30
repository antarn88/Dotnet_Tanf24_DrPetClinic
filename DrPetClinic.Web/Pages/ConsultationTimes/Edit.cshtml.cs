using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DrPetClinic.Data;
using DrPetClinic.Data.Entities;

namespace DrPetClinic.Web.Pages.ConsultationTimes
{
    public class EditModel : PageModel
    {
        private readonly DrPetClinic.Data.DrPetClinicDBContext _context;

        public EditModel(DrPetClinic.Data.DrPetClinicDBContext context)
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

            var consultationtime =  await _context.ConsultationTimes.FirstOrDefaultAsync(m => m.Id == id);
            if (consultationtime == null)
            {
                return NotFound();
            }
            ConsultationTime = consultationtime;
           ViewData["EmployeeId"] = new SelectList(_context.Employees, "Id", "Id");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(ConsultationTime).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ConsultationTimeExists(ConsultationTime.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ConsultationTimeExists(Guid id)
        {
            return _context.ConsultationTimes.Any(e => e.Id == id);
        }
    }
}
