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

        // Állatok visszaadása
        public async Task<List<AnimalDto>> GetAnimalsAsync()
        {
            var animals = await _context.Animals
                .Include(a => a.Owners)
                .Include(a => a.Treatments)
                .ToListAsync();

            return _mapper.Map<List<AnimalDto>>(animals);
        }

        public async Task<List<AnimalDetailsDto>> GetAnimalsWithDetailsAsync()
        {
            var animals = await _context.Animals
                .Include(a => a.Owners) // Eager loading a tulajdonosokkal
                .Include(a => a.Treatments) // Eager loading a kezelésekkel
                .ToListAsync();

            return animals.Select(a => new AnimalDetailsDto
            {
                Id = a.Id,
                Name = a.Name,
                Species = a.Species,
                Status = a.Status,
                OwnerNames = a.Owners.Select(o => o.Name).ToList(),
                Treatments = a.Treatments.Select(t => t.Description).ToList()!
            }).ToList();
        }

        // Egy állat lekérdezése ID alapján az Owners és Treatments adatokkal
        public async Task<AnimalDto> GetAnimalByIdAsync(Guid animalId)
        {
            var animal = await _context.Animals
                .Include(a => a.Owners)
                .Include(a => a.Treatments)
                .FirstOrDefaultAsync(a => a.Id == animalId);

            if (animal == null) throw new KeyNotFoundException("Az állat nem található.");

            return _mapper.Map<AnimalDto>(animal);
        }

        // Új állat létrehozása
        // public async Task<AnimalDto> CreateAnimalAsync(CreateAnimalDto dto)
        // {
        //     var animal = _mapper.Map<Animal>(dto);
        //     _context.Animals.Add(animal);
        //     await _context.SaveChangesAsync();

        //     return _mapper.Map<AnimalDto>(animal);
        // }

        public async Task CreateAnimalAsync(CreateAnimalDto dto)
        {
            // Új állat létrehozása
            var animal = new Animal
            {
                Id = Guid.NewGuid(),
                Name = dto.Name,
                Species = dto.Species,
                Type = dto.Type,
                BirthDate = dto.BirthDate,
                Status = dto.Status,
                Description = dto.Description
            };

            // A tulajdonos lekérése az adatbázisból
            var owner = await _context.People.FindAsync(dto.OwnerId);
            if (owner == null)
            {
                throw new KeyNotFoundException("A kiválasztott tulajdonos nem található.");
            }

            // Kapcsolat létrehozása
            animal.Owners.Add(owner);

            // Állat mentése az adatbázisba
            _context.Animals.Add(animal);
            await _context.SaveChangesAsync();
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

        // public async Task<AnimalDto> GetAnimalByIdAsync(Guid animalId)
        // {
        //     var animal = await _context.Animals
        //         .Include(a => a.Owners)
        //         .FirstOrDefaultAsync(a => a.Id == animalId);

        //     if (animal == null)
        //     {
        //         throw new KeyNotFoundException("Az állat nem található.");
        //     }

        //     return _mapper.Map<AnimalDto>(animal);
        // }

        // public async Task UpdateAnimalAsync(Guid animalId, AnimalDto animalDto)
        // {
        //     var animal = await _context.Animals
        //         .Include(a => a.Owners)
        //         .FirstOrDefaultAsync(a => a.Id == animalId);

        //     if (animal == null)
        //     {
        //         throw new KeyNotFoundException("Az állat nem található.");
        //     }

        //     _mapper.Map(animalDto, animal);
        //     _context.Animals.Update(animal);
        //     await _context.SaveChangesAsync();
        // }

        public async Task UpdateAnimalAsync(Guid animalId, AnimalDto dto)
        {
            var animal = await _context.Animals
                .Include(a => a.Owners)
                .FirstOrDefaultAsync(a => a.Id == animalId);

            if (animal == null) throw new KeyNotFoundException("Az állat nem található.");

            // Állat adatainak frissítése
            animal.Name = dto.Name;
            animal.Species = dto.Species;
            animal.Status = dto.Status;
            animal.Type = dto.Type;
            animal.BirthDate = dto.BirthDate;

            // Tulajdonosok frissítése
            var newOwners = await _context.People.Where(p => dto.OwnerIds.Contains(p.Id)).ToListAsync();
            animal.Owners.Clear();
            foreach (var owner in newOwners)
            {
                animal.Owners.Add(owner);
            }

            await _context.SaveChangesAsync();
        }

        // Állat törlése
        // public async Task DeleteAnimalAsync(Guid id)
        // {
        //     var animal = await _context.Animals.FindAsync(id);
        //     if (animal == null) throw new KeyNotFoundException("Az állat nem található.");

        //     _context.Animals.Remove(animal);
        //     await _context.SaveChangesAsync();
        // }

        public async Task<bool> DeleteAnimalAsync(Guid animalId)
        {
            var animal = await _context.Animals
                .Include(a => a.Treatments)
                .FirstOrDefaultAsync(a => a.Id == animalId);

            if (animal == null) return false;

            // Töröljük a kapcsolódó kezeléseket
            _context.Treatments.RemoveRange(animal.Treatments);

            // Töröljük az állatot
            _context.Animals.Remove(animal);

            await _context.SaveChangesAsync();

            return true;
        }
    }
}
