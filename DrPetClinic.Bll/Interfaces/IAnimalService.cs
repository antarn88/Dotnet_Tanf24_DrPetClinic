using DrPetClinic.Bll.DTOs;

namespace DrPetClinic.Bll.Services
{
    public interface IAnimalService
    {
        Task<List<AnimalDto>> GetPagedAnimalsAsync(int page, int limit);
        Task<AnimalDto> GetAnimalByIdAsync(Guid id);
        Task<AnimalDto> CreateAnimalAsync(CreateAnimalDto dto);
        Task UpdateAnimalAsync(Guid id, CreateAnimalDto dto);
        Task DeleteAnimalAsync(Guid id);
    }
}
