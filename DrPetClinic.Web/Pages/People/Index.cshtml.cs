using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DrPetClinic.Data;
using DrPetClinic.Data.Entities;

namespace DrPetClinic.Web.Pages.People
{
    public class IndexModel : PageModel
    {
        private readonly DrPetClinic.Data.DrPetClinicDBContext _context;

        public IndexModel(DrPetClinic.Data.DrPetClinicDBContext context)
        {
            _context = context;
        }

        public IList<Person> Person { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Person = await _context.People.ToListAsync();
        }
    }
}
