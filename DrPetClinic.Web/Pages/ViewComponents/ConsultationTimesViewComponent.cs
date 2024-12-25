using System.Globalization;
using DrPetClinic.Bll.DTOs;
using DrPetClinic.Bll.Interfaces;
using DrPetClinic.Bll.Services;
using DrPetClinic.Web.Enums;
using DrPetClinic.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DrPetClinic.Web.Pages.ViewComponents
{
    public class ConsultationTimesViewComponent : ViewComponent
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IConsultationTimeService _consultationTimeService;
        private readonly IEmployeeService _employeeService;

        public ConsultationTimesViewComponent(ILogger<IndexModel> logger, IConsultationTimeService consultationTimeService, IEmployeeService employeeService)
        {
            _logger = logger;
            _consultationTimeService = consultationTimeService;
            _employeeService = employeeService;
        }

        public async Task<IViewComponentResult> InvokeAsync(ViewMode mode, Guid doctorId, string startDate = null, string endDate = null)
        {
            if (mode == ViewMode.Weekly)
            {
                // Heti nézet - automatikusan az aktuális hetet tölti be
                var groupedConsultationTimes = await GetWeeklyConsultationTimes();
                return View("Weekly", groupedConsultationTimes);
            }
            else if (mode == ViewMode.Monthly)
            {
                DateTime? startDateTime = ParseDate(startDate);
                DateTime? endDateTime = ParseDate(endDate);


                var consultationTimes = startDateTime.HasValue && endDateTime.HasValue
                    ? await _consultationTimeService.GetConsultationTimesGroupedByWeekAsync(doctorId, startDateTime.Value, endDateTime.Value)
                    : new Dictionary<string, List<ConsultationTimeDto>>();

                var doctor = await _employeeService.GetEmployeeByIdAsync(doctorId);

                var viewModel = new MonthlyConsultationViewModel
                {
                    DoctorName = doctor.Name,
                    ConsultationTimes = consultationTimes,
                    StartDate = startDateTime,
                    EndDate = endDateTime,
                    DoctorId = doctorId
                };

                return View("Monthly", viewModel);
            }

            throw new ArgumentException("Érvénytelen ViewMode paraméter.");
        }

        private DateTime? ParseDate(string dateString)
        {
            if (!string.IsNullOrEmpty(dateString) && DateTime.TryParseExact(dateString, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime result))
            {
                return result;
            }
            return null;
        }


        private async Task<Dictionary<string, List<ConsultationTimeDto>>> GetWeeklyConsultationTimes()
        {
            var groupedConsultationTimes = await _consultationTimeService.GetCurrentWeekGroupedConsultationTimesAsync();
            return groupedConsultationTimes;
        }

        public static DateTime GetDateFromYearAndWeek(int year, int week, DayOfWeek dayOfWeek)
        {
            var firstDayOfYear = new DateTime(year, 1, 1);
            var daysOffset = DayOfWeek.Monday - firstDayOfYear.DayOfWeek;
            var firstMonday = firstDayOfYear.AddDays(daysOffset);
            var weekStart = firstMonday.AddDays((week - 1) * 7);
            return weekStart.AddDays((int)dayOfWeek);
        }

        private async Task<MonthlyConsultationViewModel> GetMonthlyConsultationTimes(Guid doctorId)
        {
            var doctor = await _employeeService.GetEmployeeByIdAsync(doctorId);
            var consultationTimes = await _consultationTimeService.GetConsultationTimesForNextThreeMonthsGroupedByWeekAsync(doctorId);

            return new MonthlyConsultationViewModel
            {
                DoctorName = doctor.Name,
                ConsultationTimes = consultationTimes
            };
        }
    }
}
