using AutoMapper;
using DrPetClinic.Bll.DTOs;
using DrPetClinic.Data.Entities;

namespace DrPetClinic.Bll.MappingProfiles
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<Employee, EmployeeSummaryDto>(); // Összefoglaló verzió
            CreateMap<Employee, EmployeeDetailsDto>()  // Részletes verzió
                .ForMember(dest => dest.ConsultationTimes, opt => opt.MapFrom(src => src.ConsultationTimes))
                .ForMember(dest => dest.Treatments, opt => opt.MapFrom(src => src.Treatments));

            CreateMap<CreateEmployeeDto, Employee>();
            CreateMap<ConsultationTime, ConsultationTimeDto>();
            CreateMap<Treatment, TreatmentSummaryDto>();
            CreateMap<EmployeeDetailsDto, CreateEmployeeDto>();
            CreateMap<EmployeeDetailsDto, EmployeeDto>();
        }
    }
}
