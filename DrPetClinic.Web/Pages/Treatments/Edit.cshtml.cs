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

namespace DrPetClinic.Web.Pages.Treatments
{
    public class EditModel : PageModel
    {
        private readonly DrPetClinic.Data.DrPetClinicDBContext _context;

        public EditModel(DrPetClinic.Data.DrPetClinicDBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Treatment Treatment { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var treatment =  await _context.Treatments.FirstOrDefaultAsync(m => m.Id == id);
            if (treatment == null)
            {
                return NotFound();
            }
            Treatment = treatment;
           ViewData["AnimalId"] = new SelectList(_context.Animals, "Id", "Name");
           ViewData["DoctorId"] = new SelectList(_context.Employees, "Id", "Id");
           ViewData["PersonId"] = new SelectList(_context.People, "Id", "Name");
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

            _context.Attach(Treatment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TreatmentExists(Treatment.Id))
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

        private bool TreatmentExists(Guid id)
        {
            return _context.Treatments.Any(e => e.Id == id);
        }
    }
}
