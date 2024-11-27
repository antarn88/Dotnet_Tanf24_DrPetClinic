using DrPetClinic.Bll.DTOs;

namespace DrPetClinic.Bll.Services
{
    public interface IAnimalService
    {
        Task<List<AnimalDto>> GetPagedAnimalsAsync(int page, int limit);
        Task<List<AnimalDto>> GetAnimalsAsync();
        Task<List<AnimalDetailsDto>> GetAnimalsWithDetailsAsync();
        // Task<AnimalDto> CreateAnimalAsync(CreateAnimalDto dto);
        Task CreateAnimalAsync(CreateAnimalDto dto);
        Task UpdateAnimalAsync(Guid id, CreateAnimalDto dto);
        // Task DeleteAnimalAsync(Guid id);
        Task<bool> DeleteAnimalAsync(Guid animalId);
        Task<AnimalDto> GetAnimalByIdAsync(Guid animalId);
        Task UpdateAnimalAsync(Guid animalId, AnimalDto animalDto);
    }
}
