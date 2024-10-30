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
    public class DetailsModel : PageModel
    {
        private readonly DrPetClinic.Data.DrPetClinicDBContext _context;

        public DetailsModel(DrPetClinic.Data.DrPetClinicDBContext context)
        {
            _context = context;
        }

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
    }
}
