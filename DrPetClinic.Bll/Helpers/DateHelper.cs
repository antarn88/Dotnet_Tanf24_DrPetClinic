using System.Globalization;

namespace DrPetClinic.Bll.Helpers
{
    public static class DateHelper
    {
        public static readonly Dictionary<string, int> HungarianMonthNames = new(StringComparer.OrdinalIgnoreCase)
        {
            { "januar", 1 }, { "februar", 2 }, { "marcius", 3 },
            { "aprilis", 4 }, { "majus", 5 }, { "junius", 6 },
            { "julius", 7 }, { "augusztus", 8 }, { "szeptember", 9 },
            { "oktober", 10 }, { "november", 11 }, { "december", 12 }
        };

        public static int GetMonthNumberFromName(string monthName)
        {
            if (!HungarianMonthNames.TryGetValue(monthName, out int monthNumber))
                throw new ArgumentException("Érvénytelen hónap név.", nameof(monthName));

            return monthNumber;
        }

        public static string GetHungarianDayOfWeek(DayOfWeek day) => day switch
        {
            DayOfWeek.Monday => "Hétfő",
            DayOfWeek.Tuesday => "Kedd",
            DayOfWeek.Wednesday => "Szerda",
            DayOfWeek.Thursday => "Csütörtök",
            DayOfWeek.Friday => "Péntek",
            DayOfWeek.Saturday => "Szombat",
            DayOfWeek.Sunday => "Vasárnap",
            _ => "Ismeretlen nap"
        };

        public static string GetHungarianMonthName(int month)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(month));
        }
    }
}
