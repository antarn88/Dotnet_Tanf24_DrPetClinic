using DrPetClinic.Bll.DTOs;

namespace DrPetClinic.Bll.Services
{
    public interface ITreatmentService
    {
        Task<List<TreatmentSummaryDto>> GetPagedTreatmentsAsync(int page, int limit);
        Task<TreatmentDetailsDto> GetTreatmentByIdAsync(Guid id);
        Task<TreatmentDetailsDto> CreateTreatmentAsync(CreateTreatmentDto dto);
        Task UpdateTreatmentAsync(Guid id, CreateTreatmentDto dto);
        Task DeleteTreatmentAsync(Guid id);
    }
}
