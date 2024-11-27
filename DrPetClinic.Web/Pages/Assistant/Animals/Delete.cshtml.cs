using DrPetClinic.Bll.DTOs;
using DrPetClinic.Bll.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DrPetClinic.Web.Pages.Assistant.Animals
{
    public class DeleteModel : PageModel
    {
        private readonly IAnimalService _animalService;

        public DeleteModel(IAnimalService animalService)
        {
            _animalService = animalService;
        }

        [BindProperty]
        public AnimalDto Animal { get; set; }

        public async Task<IActionResult> OnGetAsync(Guid animalId)
        {
            Animal = await _animalService.GetAnimalByIdAsync(animalId);

            if (Animal == null)
            {
                return RedirectToPage("/Assistant/Animals/Index");
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(Guid animalId)
        {
            var success = await _animalService.DeleteAnimalAsync(animalId);

            if (!success)
            {
                ModelState.AddModelError(string.Empty, "Nem sikerült az állatot törölni.");
                return Page();
            }

            return RedirectToPage("/Assistant/Animals/Index");
        }
    }
}
