using AutoMapper;
using DrPetClinic.Bll.DTOs;
using DrPetClinic.Data;
using DrPetClinic.Data.Entities;
using DrPetClinic.Data.Enums;
using Microsoft.EntityFrameworkCore;

namespace DrPetClinic.Bll.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly DrPetClinicDBContext _context;
        private readonly IMapper _mapper;

        public EmployeeService(DrPetClinicDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // Lapozott lista lekérdezése az ConsultationTimes és Treatments adatokkal
        public async Task<List<EmployeeDetailsDto>> GetPagedEmployeesAsync(int page, int limit)
        {
            var employees = await _context.Employees
                .Include(e => e.ConsultationTimes)
                .Include(e => e.Treatments)
                .Skip((page - 1) * limit)
                .Take(limit)
                .ToListAsync();

            return _mapper.Map<List<EmployeeDetailsDto>>(employees);
        }

        public async Task<List<EmployeeDto>> GetDoctorsAsync()
        {
            var doctors = await _context.Employees
                .Where(e => e.Type == EmployeeType.Doctor)
                .OrderBy(e => e.Name)
                .ToListAsync();

            return _mapper.Map<List<EmployeeDto>>(doctors);
        }

        // Egy alkalmazott lekérdezése ID alapján a ConsultationTimes és Treatments adatokkal
        public async Task<EmployeeDetailsDto> GetEmployeeByIdAsync(Guid id)
        {
            var employee = await _context.Employees
                .Include(e => e.ConsultationTimes)
                .Include(e => e.Treatments)
                .FirstOrDefaultAsync(e => e.Id == id);

            if (employee == null) throw new KeyNotFoundException("Az alkalmazott nem található.");

            return _mapper.Map<EmployeeDetailsDto>(employee);
        }

        // Új alkalmazott létrehozása
        public async Task<EmployeeDetailsDto> CreateEmployeeAsync(CreateEmployeeDto dto)
        {
            var employee = _mapper.Map<Employee>(dto);
            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();

            return _mapper.Map<EmployeeDetailsDto>(employee);
        }

        // Alkalmazott módosítása
        public async Task UpdateEmployeeAsync(Guid id, CreateEmployeeDto dto)
        {
            var employee = await _context.Employees.FindAsync(id);
            if (employee == null) throw new KeyNotFoundException("Az alkalmazott nem található.");

            _mapper.Map(dto, employee);
            _context.Employees.Update(employee);
            await _context.SaveChangesAsync();
        }

        // Alkalmazott törlése
        public async Task DeleteEmployeeAsync(Guid id)
        {
            var employee = await _context.Employees.FindAsync(id);
            if (employee == null) throw new KeyNotFoundException("Az alkalmazott nem található.");

            _context.Employees.Remove(employee);
            await _context.SaveChangesAsync();
        }
    }
}
