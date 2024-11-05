using AutoMapper;
using DrPetClinic.Bll.DTOs;
using DrPetClinic.Data;
using DrPetClinic.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace DrPetClinic.Bll.Services
{
    public class AnimalService : IAnimalService
    {
        private readonly DrPetClinicDBContext _context;
        private readonly IMapper _mapper;

        public AnimalService(DrPetClinicDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // Lapozott lista lekérdezése az Owners és Treatments adatokkal
        public async Task<List<AnimalDto>> GetPagedAnimalsAsync(int page, int limit)
        {
            var animals = await _context.Animals
                .Include(a => a.Owners)
                .Include(a => a.Treatments)
                .Skip((page - 1) * limit)
                .Take(limit)
                .ToListAsync();

            return _mapper.Map<List<AnimalDto>>(animals);
        }

        // Egy állat lekérdezése ID alapján az Owners és Treatments adatokkal
        public async Task<AnimalDto> GetAnimalByIdAsync(Guid id)
        {
            var animal = await _context.Animals
                .Include(a => a.Owners)
                .Include(a => a.Treatments)
                .FirstOrDefaultAsync(a => a.Id == id);

            if (animal == null) throw new KeyNotFoundException("Az állat nem található.");

            return _mapper.Map<AnimalDto>(animal);
        }

        // Új állat létrehozása
        public async Task<AnimalDto> CreateAnimalAsync(CreateAnimalDto dto)
        {
            var animal = _mapper.Map<Animal>(dto);
            _context.Animals.Add(animal);
            await _context.SaveChangesAsync();

            return _mapper.Map<AnimalDto>(animal);
        }

        // Állat módosítása
        public async Task UpdateAnimalAsync(Guid id, CreateAnimalDto dto)
        {
            var animal = await _context.Animals.FindAsync(id);
            if (animal == null) throw new KeyNotFoundException("Az állat nem található.");

            _mapper.Map(dto, animal);
            _context.Animals.Update(animal);
            await _context.SaveChangesAsync();
        }

        // Állat törlése
        public async Task DeleteAnimalAsync(Guid id)
        {
            var animal = await _context.Animals.FindAsync(id);
            if (animal == null) throw new KeyNotFoundException("Az állat nem található.");

            _context.Animals.Remove(animal);
            await _context.SaveChangesAsync();
        }
    }
}
