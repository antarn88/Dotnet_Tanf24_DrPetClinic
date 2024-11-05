using AutoMapper;
using DrPetClinic.Bll.DTOs;
using DrPetClinic.Data;
using DrPetClinic.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace DrPetClinic.Bll.Services
{
    public class TreatmentService : ITreatmentService
    {
        private readonly DrPetClinicDBContext _context;
        private readonly IMapper _mapper;

        public TreatmentService(DrPetClinicDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // Lapozott lista lekérdezése
        public async Task<List<TreatmentSummaryDto>> GetPagedTreatmentsAsync(int page, int limit)
        {
            var treatments = await _context.Treatments
                .Skip((page - 1) * limit)
                .Take(limit)
                .ToListAsync();

            return _mapper.Map<List<TreatmentSummaryDto>>(treatments);
        }

        // Kezelés lekérdezése ID alapján
        public async Task<TreatmentDetailsDto> GetTreatmentByIdAsync(Guid id)
        {
            var treatment = await _context.Treatments
                .Include(t => t.Doctor)
                .Include(t => t.Animal)
                .Include(t => t.Person)
                .Include(t => t.Entries)
                .FirstOrDefaultAsync(t => t.Id == id);

            if (treatment == null) throw new KeyNotFoundException("A kezelés nem található.");

            return _mapper.Map<TreatmentDetailsDto>(treatment);
        }

        // Új kezelés létrehozása
        public async Task<TreatmentDetailsDto> CreateTreatmentAsync(CreateTreatmentDto dto)
        {
            var treatment = _mapper.Map<Treatment>(dto);
            _context.Treatments.Add(treatment);
            await _context.SaveChangesAsync();

            return _mapper.Map<TreatmentDetailsDto>(treatment);
        }

        // Kezelés módosítása
        public async Task UpdateTreatmentAsync(Guid id, CreateTreatmentDto dto)
        {
            var treatment = await _context.Treatments.FindAsync(id);
            if (treatment == null) throw new KeyNotFoundException("A kezelés nem található.");

            _mapper.Map(dto, treatment);
            _context.Treatments.Update(treatment);
            await _context.SaveChangesAsync();
        }

        // Kezelés törlése
        public async Task DeleteTreatmentAsync(Guid id)
        {
            var treatment = await _context.Treatments.FindAsync(id);
            if (treatment == null) throw new KeyNotFoundException("A kezelés nem található.");

            _context.Treatments.Remove(treatment);
            await _context.SaveChangesAsync();
        }
    }
}
