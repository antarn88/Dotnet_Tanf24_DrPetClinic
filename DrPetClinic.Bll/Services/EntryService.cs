using AutoMapper;
using DrPetClinic.Bll.DTOs;
using DrPetClinic.Data;
using DrPetClinic.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace DrPetClinic.Bll.Services
{
    public class EntryService : IEntryService
    {
        private readonly DrPetClinicDBContext _context;
        private readonly IMapper _mapper;

        public EntryService(DrPetClinicDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // Lapozott lista lekérdezése
        public async Task<List<EntrySummaryDto>> GetPagedEntriesAsync(int page, int limit)
        {
            var entries = await _context.Entries
                .Skip((page - 1) * limit)
                .Take(limit)
                .ToListAsync();

            return _mapper.Map<List<EntrySummaryDto>>(entries);
        }

        // Bejegyzés lekérdezése ID alapján
        public async Task<EntryDetailsDto> GetEntryByIdAsync(Guid id)
        {
            var entry = await _context.Entries
                .Include(e => e.History)
                .Include(e => e.Treatment)
                .FirstOrDefaultAsync(e => e.Id == id);

            if (entry == null) throw new KeyNotFoundException("A bejegyzés nem található.");

            return _mapper.Map<EntryDetailsDto>(entry);
        }

        // Új bejegyzés létrehozása
        public async Task<EntryDetailsDto> CreateEntryAsync(CreateEntryDto dto)
        {
            var entry = _mapper.Map<Entry>(dto);
            _context.Entries.Add(entry);
            await _context.SaveChangesAsync();

            return _mapper.Map<EntryDetailsDto>(entry);
        }

        // Bejegyzés módosítása
        public async Task UpdateEntryAsync(Guid id, CreateEntryDto dto)
        {
            var entry = await _context.Entries.FindAsync(id);
            if (entry == null) throw new KeyNotFoundException("A bejegyzés nem található.");

            _mapper.Map(dto, entry);
            _context.Entries.Update(entry);
            await _context.SaveChangesAsync();
        }

        // Bejegyzés törlése
        public async Task DeleteEntryAsync(Guid id)
        {
            var entry = await _context.Entries.FindAsync(id);
            if (entry == null) throw new KeyNotFoundException("A bejegyzés nem található.");

            _context.Entries.Remove(entry);
            await _context.SaveChangesAsync();
        }
    }
}
