using AutoMapper;
using DrPetClinic.Bll.DTOs;
using DrPetClinic.Data.Entities;

namespace DrPetClinic.Bll.MappingProfiles
{
    public class TreatmentProfile : Profile
    {
        public TreatmentProfile()
        {
            CreateMap<Treatment, TreatmentSummaryDto>();
            CreateMap<Treatment, TreatmentDetailsDto>()
                .ForMember(dest => dest.Doctor, opt => opt.MapFrom(src => src.Doctor))
                .ForMember(dest => dest.Animal, opt => opt.MapFrom(src => src.Animal))
                .ForMember(dest => dest.Person, opt => opt.MapFrom(src => src.Person))
                .ForMember(dest => dest.Entries, opt => opt.MapFrom(src => src.Entries));

            CreateMap<CreateTreatmentDto, Treatment>();
            CreateMap<Entry, EntrySummaryDto>();
            CreateMap<Employee, EmployeeDto>();
            CreateMap<Animal, AnimalDto>();
            CreateMap<Person, PersonSummaryDto>();
        }
    }
}
