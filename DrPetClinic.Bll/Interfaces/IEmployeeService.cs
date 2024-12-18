﻿using DrPetClinic.Bll.DTOs;

namespace DrPetClinic.Bll.Services
{
    public interface IEmployeeService
    {
        Task<List<EmployeeDetailsDto>> GetPagedEmployeesAsync(int page, int limit);
        Task<List<EmployeeDto>> GetDoctorsAsync();
        Task<List<string>> GetEmployeeTypesAsync();
        Task<EmployeeDetailsDto> GetEmployeeByIdAsync(Guid id);
        Task<EmployeeDetailsDto> CreateEmployeeAsync(CreateEmployeeDto dto);
        Task UpdateEmployeeAsync(Guid id, CreateEmployeeDto dto);
        Task UpdateEmployeeWithConsultationTimesAsync(Guid id, EmployeeDetailsDto dto);
        Task DeleteEmployeeAsync(Guid id);
    }
}
