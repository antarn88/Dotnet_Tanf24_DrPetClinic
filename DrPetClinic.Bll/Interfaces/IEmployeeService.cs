using DrPetClinic.Bll.DTOs;

namespace DrPetClinic.Bll.Services
{
    public interface IEmployeeService
    {
        Task<List<EmployeeDetailsDto>> GetPagedEmployeesAsync(int page, int limit);
        Task<EmployeeDetailsDto> GetEmployeeByIdAsync(Guid id);
        Task<EmployeeDetailsDto> CreateEmployeeAsync(CreateEmployeeDto dto);
        Task UpdateEmployeeAsync(Guid id, CreateEmployeeDto dto);
        Task DeleteEmployeeAsync(Guid id);
    }
}
