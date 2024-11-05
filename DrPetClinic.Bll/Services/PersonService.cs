using AutoMapper;
using DrPetClinic.Bll.DTOs;
using DrPetClinic.Data;
using DrPetClinic.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace DrPetClinic.Bll.Services
{
    public class PersonService : IPersonService
    {
        private readonly DrPetClinicDBContext _context;
        private readonly IMapper _mapper;

        public PersonService(DrPetClinicDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // Lapozott lista lekérdezése az Animals és Treatments adatokkal
        public async Task<List<PersonSummaryDto>> GetPagedPersonsAsync(int page, int limit)
        {
            var persons = await _context.People
                .Skip((page - 1) * limit)
                .Take(limit)
                .ToListAsync();

            return _mapper.Map<List<PersonSummaryDto>>(persons);
        }

        // Egy személy lekérdezése ID alapján az Animals és Treatments adatokkal
        public async Task<PersonDetailsDto> GetPersonByIdAsync(Guid id)
        {
            var person = await _context.People
                .Include(p => p.Animals)
                .Include(p => p.Treatments)
                .FirstOrDefaultAsync(p => p.Id == id);

            if (person == null) throw new KeyNotFoundException("A személy nem található.");

            return _mapper.Map<PersonDetailsDto>(person);
        }

        // Új személy létrehozása
        public async Task<PersonDetailsDto> CreatePersonAsync(CreatePersonDto dto)
        {
            var person = _mapper.Map<Person>(dto);
            _context.People.Add(person);
            await _context.SaveChangesAsync();

            return _mapper.Map<PersonDetailsDto>(person);
        }

        // Személy módosítása
        public async Task UpdatePersonAsync(Guid id, CreatePersonDto dto)
        {
            var person = await _context.People.FindAsync(id);
            if (person == null) throw new KeyNotFoundException("A személy nem található.");

            _mapper.Map(dto, person);
            _context.People.Update(person);
            await _context.SaveChangesAsync();
        }

        // Személy törlése
        public async Task DeletePersonAsync(Guid id)
        {
            var person = await _context.People.FindAsync(id);
            if (person == null) throw new KeyNotFoundException("A személy nem található.");

            _context.People.Remove(person);
            await _context.SaveChangesAsync();
        }
    }
}
