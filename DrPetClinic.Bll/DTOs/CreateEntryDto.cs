using DrPetClinic.Data.Enums;

namespace DrPetClinic.Bll.DTOs
{
    public class CreateEntryDto
    {
        public string? Description { get; set; }
        public EntryType Type { get; set; }
        public string? Medicine { get; set; }
        public int? Length { get; set; }
        public Guid? HistoryId { get; set; }
        public Guid TreatmentId { get; set; }
    }
}
