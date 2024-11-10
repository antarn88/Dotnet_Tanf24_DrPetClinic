using AutoMapper;
using DrPetClinic.Bll.DTOs;
using DrPetClinic.Bll.Helpers;
using DrPetClinic.Bll.Interfaces;
using DrPetClinic.Data;
using DrPetClinic.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace DrPetClinic.Bll.Services
{
    public class ConsultationTimeService : IConsultationTimeService
    {
        private readonly DrPetClinicDBContext _context;
        private readonly IMapper _mapper;

        public ConsultationTimeService(DrPetClinicDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<ConsultationTimeDto>> GetConsultationTimesByYearAndMonthAsync(int year, int month)
        {
            var consultationTimes = await _context.ConsultationTimes
                .Include(c => c.Employee)
                .Where(ct => ct.Year == year && ct.Month == month)
                .OrderBy(ct => ct.DayOfWeek)
                .ToListAsync();

            return _mapper.Map<List<ConsultationTimeDto>>(consultationTimes);
        }

        public async Task<List<ConsultationTimeDto>> GetConsultationTimesByYearAndMonthAsync(int year, string month)
        {
            int monthNumber = DateHelper.GetMonthNumberFromName(month);
            return await GetConsultationTimesByYearAndMonthAsync(year, monthNumber);
        }

        public async Task<List<ConsultationTimeDto>> GetPagedConsultationTimesAsync(int page, int limit)
        {
            var consultationTimes = await _context.ConsultationTimes
                .Include(c => c.Employee)
                .Skip((page - 1) * limit)
                .Take(limit)
                .ToListAsync();

            return _mapper.Map<List<ConsultationTimeDto>>(consultationTimes);
        }

        public async Task<ConsultationTimeDto> GetConsultationTimeByIdAsync(Guid id)
        {
            var consultationTime = await _context.ConsultationTimes
               .Include(c => c.Employee)
               .FirstOrDefaultAsync(c => c.Id == id);

            if (consultationTime == null) throw new KeyNotFoundException("A keresett rendelési idő nem található.");

            return _mapper.Map<ConsultationTimeDto>(consultationTime);
        }

        public async Task<ConsultationTimeDto> CreateConsultationTimeAsync(CreateConsultationTimeDto dto)
        {
            var consultationTime = _mapper.Map<ConsultationTime>(dto);
            _context.ConsultationTimes.Add(consultationTime);
            await _context.SaveChangesAsync();

            return _mapper.Map<ConsultationTimeDto>(consultationTime);
        }

        public async Task UpdateConsultationTimeAsync(Guid id, CreateConsultationTimeDto dto)
        {
            var consultationTime = await _context.ConsultationTimes.FindAsync(id);
            if (consultationTime == null) throw new KeyNotFoundException("A keresett rendelési idő nem található.");

            _mapper.Map(dto, consultationTime);
            _context.ConsultationTimes.Update(consultationTime);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteConsultationTimeAsync(Guid id)
        {
            var consultationTime = await _context.ConsultationTimes.FindAsync(id);
            if (consultationTime == null) throw new KeyNotFoundException("A keresett rendelési idő nem található.");

            _context.ConsultationTimes.Remove(consultationTime);
            await _context.SaveChangesAsync();
        }
    }
}