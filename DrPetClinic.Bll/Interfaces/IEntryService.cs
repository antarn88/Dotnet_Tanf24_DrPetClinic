using DrPetClinic.Bll.DTOs;

namespace DrPetClinic.Bll.Services
{
    public interface IEntryService
    {
        Task<List<EntrySummaryDto>> GetPagedEntriesAsync(int page, int limit);
        Task<EntryDetailsDto> GetEntryByIdAsync(Guid id);
        Task<EntryDetailsDto> CreateEntryAsync(CreateEntryDto dto);
        Task UpdateEntryAsync(Guid id, CreateEntryDto dto);
        Task DeleteEntryAsync(Guid id);
    }
}
