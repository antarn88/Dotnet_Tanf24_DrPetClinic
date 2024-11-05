using DrPetClinic.Data.Enums;

namespace DrPetClinic.Bll.DTOs
{
    public class EntryDetailsDto
    {
        public Guid Id { get; set; }
        public string? Description { get; set; }
        public EntryType Type { get; set; }
        public string? Medicine { get; set; }
        public int? Length { get; set; }
        public Guid? HistoryId { get; set; }
        public EntrySummaryDto? History { get; set; } // Kapcsolódó előzmény bejegyzés
        public Guid TreatmentId { get; set; }
        public TreatmentSummaryDto Treatment { get; set; } // Kapcsolódó kezelés
    }
}
