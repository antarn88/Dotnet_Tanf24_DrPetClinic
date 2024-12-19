using DrPetClinic.Web.Enums;
using Microsoft.AspNetCore.Mvc;

namespace DrPetClinic.Web.Pages.ViewComponents;

public class ConsultationTimesViewComponent : ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync(ViewMode mode)
    {
        if (mode == ViewMode.Weekly)
        {
            // Heti nézet - automatikusan az aktuális hetet tölti be
            var weeklyData = await GetWeeklyConsultationTimes();
            return View("Weekly", weeklyData);
        }
        else if (mode == ViewMode.Monthly)
        {
            // Havi nézet - üres tábla jelenik meg, a felhasználónak meg kell adnia a szűrési feltételeket
            return View("Monthly", new { Data = "Adat lesz" });
        }

        throw new ArgumentException("Érvénytelen ViewMode paraméter.");
    }

    private async Task<object> GetWeeklyConsultationTimes()
    {
        // Itt történik az adatbázis-lekérdezés
        await Task.Delay(100); // szimulált adatbázis-lekérdezés
        return new { Title = "Weekly View", Data = "Heti időpontok adatai" };
    }
}
