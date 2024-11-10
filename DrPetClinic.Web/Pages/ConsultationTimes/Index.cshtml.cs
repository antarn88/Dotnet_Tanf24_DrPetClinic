using DrPetClinic.Bll.DTOs;
using DrPetClinic.Bll.Helpers;
using DrPetClinic.Bll.Interfaces;
using Microsoft.AspNetCore.Html;
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
            if (!ev.HasValue || string.IsNullOrWhiteSpace(honap))
            {
                GroupedConsultationTimes = [];
                return;
            }

            if (int.TryParse(honap, out int monthNumber))
            {
                if (monthNumber < 1 || monthNumber > 12)
                {
                    ModelState.AddModelError("Honap", "A hónapnak 1 és 12 közé kell esnie.");
                    return;
                }
            }
            else
            {
                try
                {
                    monthNumber = DateHelper.GetMonthNumberFromName(honap);
                }
                catch (ArgumentException ex)
                {
                    ModelState.AddModelError("Honap", ex.Message);
                    return;
                }
            }

            var consultationTimes = await _consultationTimeService.GetConsultationTimesByYearAndMonthAsync(ev.Value, monthNumber);
            GroupedConsultationTimes = consultationTimes
                .GroupBy(ct => ct.Employee.Name)
                .ToDictionary(g => g.Key, g => g.ToList());
        }

        public string GetHungarianMonthName(int month) => DateHelper.GetHungarianMonthName(month);

        public IHtmlContent FormatWeeklyConsultationTimes(List<ConsultationTimeDto> consultationTimes)
        {
            var groupedByWeek = consultationTimes
                .GroupBy(ct => ct.Week)
                .Select(weekGroup =>
                    $"{weekGroup.Key}. hét - " +
                    string.Join("; ", weekGroup.Select(ct =>
                        $"{DateHelper.GetHungarianDayOfWeek(ct.DayOfWeek)} {ct.StartTime:hh\\:mm}-{ct.EndTime:hh\\:mm}"))
                );

            var resultHtml = string.Join("<br/>", groupedByWeek);
            return new HtmlString(resultHtml);
        }
    }
}
