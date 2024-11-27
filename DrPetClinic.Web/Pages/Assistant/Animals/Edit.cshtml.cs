using DrPetClinic.Bll.DTOs;
using DrPetClinic.Bll.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DrPetClinic.Web.Pages.Assistant.Animals
{
    public class EditModel : PageModel
    {
        private readonly IAnimalService _animalService;

        public EditModel(IAnimalService animalService)
        {
            _animalService = animalService;
        }

        [BindProperty]
        public AnimalDto Animal { get; set; }

        public string OwnerName { get; set; }
        public List<OwnerDto> Owners { get; set; } = [];

        public async Task<IActionResult> OnGetAsync(Guid animalId)
        {
            Animal = await _animalService.GetAnimalByIdAsync(animalId);
            if (Animal == null)
            {
                return NotFound();
            }

            // Tulajdonos nevének lekérdezése
            var owner = Animal.Owners.FirstOrDefault();

            Owners.Add(owner!);
            OwnerName = owner?.Name ?? "Nincs tulajdonos";

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            await _animalService.UpdateAnimalAsync(Animal.Id, Animal);
            return RedirectToPage("/Assistant/Animals/Index");
        }
    }
}
