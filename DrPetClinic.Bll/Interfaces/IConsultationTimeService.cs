using DrPetClinic.Bll.DTOs;

namespace DrPetClinic.Bll.Interfaces
{
    public interface IConsultationTimeService
    {
        Task<List<ConsultationTimeDto>> GetPagedConsultationTimesAsync(int page, int limit);
        Task<ConsultationTimeDto> GetConsultationTimeByIdAsync(Guid id);
        Task<ConsultationTimeDto> CreateConsultationTimeAsync(CreateConsultationTimeDto dto);
        Task UpdateConsultationTimeAsync(Guid id, CreateConsultationTimeDto dto);
        Task DeleteConsultationTimeAsync(Guid id);
    }
}
