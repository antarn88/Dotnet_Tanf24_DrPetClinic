using AutoMapper;
using DrPetClinic.Bll.DTOs;
using DrPetClinic.Bll.Helpers;
using DrPetClinic.Bll.Interfaces;
using DrPetClinic.Data;
using DrPetClinic.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

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

        public async Task<Dictionary<string, List<ConsultationTimeDto>>> GetGroupedConsultationTimesByYearAndMonthAsync(int year, int month)
        {
            var consultationTimes = await _context.ConsultationTimes
                .Include(c => c.Employee)
                .Where(ct => ct.Year == year && ct.Month == month)
                .OrderBy(ct => ct.DayOfWeek)
                .ToListAsync();

            var groupedConsultationTimes = consultationTimes
                .GroupBy(ct => ct.Employee!.Name)
                .ToDictionary(g => g.Key, g => _mapper.Map<List<ConsultationTimeDto>>(g.ToList()));

            return groupedConsultationTimes;
        }

        public async Task<Dictionary<string, List<ConsultationTimeDto>>> GetCurrentWeekGroupedConsultationTimesAsync()
        {
            var currentYear = DateTime.Now.Year;
            var currentWeek = CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(DateTime.Now, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);

            var weeklyConsultationTimes = await _context.ConsultationTimes
                .Include(c => c.Employee)
                .Where(ct => ct.Year == currentYear && ct.Week == currentWeek)
                .OrderBy(ct => ct.DayOfWeek)
                .ToListAsync();

            return weeklyConsultationTimes
                .GroupBy(ct => ct.Employee!.Name)
                .ToDictionary(g => g.Key, g => _mapper.Map<List<ConsultationTimeDto>>(g.ToList()));
        }
        public async Task<Dictionary<string, List<ConsultationTimeDto>>> GetConsultationTimesForNextThreeMonthsGroupedByWeekAsync(Guid employeeId)
        {
            var today = DateTime.Today;
            var threeMonthsLater = today.AddMonths(3);

            int startYear = today.Year;
            int startMonth = today.Month;
            int endYear = threeMonthsLater.Year;
            int endMonth = threeMonthsLater.Month;

            var consultationTimes = await _context.ConsultationTimes
                .Include(ct => ct.Employee)
                .Where(ct => ct.EmployeeId == employeeId && ((ct.Year == startYear && ct.Month >= startMonth) || (ct.Year == endYear && ct.Month <= endMonth) || (ct.Year > startYear && ct.Year < endYear)))
                .OrderBy(ct => ct.Year)
                .ThenBy(ct => ct.Month)
                .ThenBy(ct => ct.Week)
                .ThenBy(ct => ct.DayOfWeek)
                .ToListAsync();

            var groupedByWeek = consultationTimes
                .GroupBy(ct => $"{ct.Year}-{ct.Month}-{ct.Week}")
                .ToDictionary(g => g.Key, g => g.OrderBy(ct => ct.DayOfWeek).ToList());

            return _mapper.Map<Dictionary<string, List<ConsultationTimeDto>>>(groupedByWeek);
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

        public async Task<List<ConsultationTimeDto>> GetConsultationTimesByDoctorIdAsync(Guid doctorId)
        {
            var consultationTimes = await _context.ConsultationTimes
                .Where(ct => ct.EmployeeId == doctorId)
                .OrderBy(ct => ct.Week)
                .ThenBy(ct => ct.DayOfWeek)
                .ToListAsync();

            return _mapper.Map<List<ConsultationTimeDto>>(consultationTimes);
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

        public async Task UpdateConsultationTimesAsync(Guid doctorId, List<CreateConsultationTimeDto> consultationTimes)
        {
            var existingConsultationTimes = await _context.ConsultationTimes
                .Where(ct => ct.EmployeeId == doctorId)
                .ToListAsync();

            foreach (var dto in consultationTimes)
            {
                var consultationTime = existingConsultationTimes.FirstOrDefault(ct => ct.Id == dto.Id);

                if (consultationTime != null)
                {
                    // Meglévő rendelési idő frissítése
                    _mapper.Map(dto, consultationTime);
                }
                else
                {
                    // Új rendelési idő hozzáadása
                    var newConsultationTime = _mapper.Map<ConsultationTime>(dto);
                    newConsultationTime.EmployeeId = doctorId;
                    _context.ConsultationTimes.Add(newConsultationTime);
                }
            }

            // Nem létező rendelési idők törlése
            var idsToKeep = consultationTimes.Select(ct => ct.Id).ToHashSet();
            var timesToRemove = existingConsultationTimes
                .Where(ct => !idsToKeep.Contains(ct.Id))
                .ToList();

            _context.ConsultationTimes.RemoveRange(timesToRemove);

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