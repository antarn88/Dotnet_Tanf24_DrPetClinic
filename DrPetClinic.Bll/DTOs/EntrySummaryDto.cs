using DrPetClinic.Data.Enums;

namespace DrPetClinic.Bll.DTOs
{
    public class EntrySummaryDto
    {
        public Guid Id { get; set; }
        public string? Description { get; set; }
        public EntryType Type { get; set; }
        public string? Medicine { get; set; }
        public int? Length { get; set; }
    }
}
