using DrPetClinic.Bll.DTOs;
using DrPetClinic.Bll.Helpers;
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

        public Dictionary<string, List<ConsultationTimeDto>> GroupedConsultationTimes { get; set; } = [];

        public async Task OnGetAsync(int? ev = null, string honap = "")
        {
            if (!int.TryParse(honap, out int monthNumber))
            {
                try
                {
                    monthNumber = DateHelper.GetMonthNumberFromName(honap);
                }
                catch (ArgumentException)
                {
                    return;
                }
            }

            GroupedConsultationTimes = await _consultationTimeService.GetGroupedConsultationTimesByYearAndMonthAsync(ev!.Value, monthNumber);
        }
    }
}
