using DrPetClinic.Bll.DTOs;
using DrPetClinic.Bll.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DrPetClinic.Web.Pages.Assistant.Animals
{
    public class IndexModel : PageModel
    {
        private readonly IAnimalService AnimalService;

        public List<AnimalDetailsDto> Animals { get; set; }

        public IndexModel(IAnimalService animalService)
        {
            AnimalService = animalService;
        }

        public async Task OnGetAsync()
        {
            Animals = await AnimalService.GetAnimalsWithDetailsAsync();
        }
    }
}
