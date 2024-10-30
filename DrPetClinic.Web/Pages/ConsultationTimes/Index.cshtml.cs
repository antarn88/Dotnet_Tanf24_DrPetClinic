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
    public class IndexModel : PageModel
    {
        private readonly DrPetClinic.Data.DrPetClinicDBContext _context;

        public IndexModel(DrPetClinic.Data.DrPetClinicDBContext context)
        {
            _context = context;
        }

        public IList<ConsultationTime> ConsultationTime { get;set; } = default!;

        public async Task OnGetAsync()
        {
            ConsultationTime = await _context.ConsultationTimes
                .Include(c => c.Employee).ToListAsync();
        }
    }
}
