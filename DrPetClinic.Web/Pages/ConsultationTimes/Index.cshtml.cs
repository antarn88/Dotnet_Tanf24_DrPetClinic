using DrPetClinic.Bll.DTOs;
using DrPetClinic.Bll.Interfaces;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DrPetClinic.Web.Pages.ConsultationTimes
{
    public class IndexModel : PageModel
    {
        private readonly IConsultationTimeService _consultationTimeService;

        public IndexModel(IConsultationTimeService consultationTimeService)
        {
            _consultationTimeService = consultationTimeService;
        }

        public IList<ConsultationTimeDto> ConsultationTime { get; set; }

        public async Task OnGetAsync()
        {
            ConsultationTime = await _consultationTimeService.GetPagedConsultationTimesAsync(1, 10);
        }
    }
}
