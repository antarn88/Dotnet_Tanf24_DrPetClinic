﻿using DrPetClinic.Bll.DTOs;

namespace DrPetClinic.Bll.Interfaces
{
    public interface IConsultationTimeService
    {
        Task<List<ConsultationTimeDto>> GetPagedConsultationTimesAsync(int page, int limit);
        Task<ConsultationTimeDto> GetConsultationTimeByIdAsync(Guid id);
        Task<List<ConsultationTimeDto>> GetConsultationTimesByYearAndMonthAsync(int year, int month);
        Task<List<ConsultationTimeDto>> GetConsultationTimesByYearAndMonthAsync(int year, string month);
        Task<Dictionary<string, List<ConsultationTimeDto>>> GetGroupedConsultationTimesByYearAndMonthAsync(int year, int month);
        Task<Dictionary<string, List<ConsultationTimeDto>>> GetConsultationTimesForNextThreeMonthsGroupedByWeekAsync(Guid employeeId);
        Task<Dictionary<string, List<ConsultationTimeDto>>> GetCurrentWeekGroupedConsultationTimesAsync();
        Task<ConsultationTimeDto> CreateConsultationTimeAsync(CreateConsultationTimeDto dto);
        Task UpdateConsultationTimeAsync(Guid id, CreateConsultationTimeDto dto);
        Task DeleteConsultationTimeAsync(Guid id);
    }
}
