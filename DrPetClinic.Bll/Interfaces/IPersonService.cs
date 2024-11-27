using DrPetClinic.Bll.DTOs;

namespace DrPetClinic.Bll.Services
{
    public interface IPersonService
    {
        Task<List<PersonSummaryDto>> GetPagedPersonsAsync(int page, int limit);
        Task<PersonDetailsDto> GetPersonByIdAsync(Guid id);
        Task<List<PersonSummaryDto>> GetAllOwnersAsync();
        Task<PersonDetailsDto> CreatePersonAsync(CreatePersonDto dto);
        Task UpdatePersonAsync(Guid id, CreatePersonDto dto);
        Task DeletePersonAsync(Guid id);
    }
}
