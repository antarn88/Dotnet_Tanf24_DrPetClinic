using DrPetClinic.Bll.DTOs;
using DrPetClinic.Bll.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DrPetClinic.Web.Pages.Assistant.Animals
{
    public class CreateModel : PageModel
    {
        private readonly IAnimalService _animalService;
        private readonly IPersonService _personService;

        public CreateModel(IAnimalService animalService, IPersonService personService)
        {
            _animalService = animalService;
            _personService = personService;
        }

        [BindProperty]
        public CreateAnimalDto Animal { get; set; } = new();

        [BindProperty]
        public Guid SelectedOwnerId { get; set; }

        public List<SelectListItem> OwnerList { get; set; }

        public async Task OnGetAsync()
        {
            // Lekérdezzük a tulajdonosokat a select listához
            var owners = await _personService.GetAllOwnersAsync();
            OwnerList = owners.Select(o => new SelectListItem
            {
                Value = o.Id.ToString(),
                Text = o.Name
            }).ToList();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                // Újratöltjük a tulajdonos listát, ha a validáció nem sikerült
                var owners = await _personService.GetAllOwnersAsync();
                OwnerList = owners.Select(o => new SelectListItem
                {
                    Value = o.Id.ToString(),
                    Text = o.Name
                }).ToList();

                return Page();
            }

            // Beállítjuk az új állathoz a tulajdonost
            Animal.OwnerId = SelectedOwnerId;

            // Új állat létrehozása
            await _animalService.CreateAnimalAsync(Animal);

            return RedirectToPage("/Assistant/Animals/Index");
        }
    }
}
