using AutoMapper;
using DrPetClinic.Bll.DTOs;
using DrPetClinic.Data.Entities;

namespace DrPetClinic.Bll.MappingProfiles
{
    public class PersonProfile : Profile
    {
        public PersonProfile()
        {
            CreateMap<Person, PersonSummaryDto>(); // Összefoglaló verzió
            CreateMap<Person, PersonDetailsDto>()  // Részletes verzió
                .ForMember(dest => dest.Animals, opt => opt.MapFrom(src => src.Animals))
                .ForMember(dest => dest.Treatments, opt => opt.MapFrom(src => src.Treatments));

            CreateMap<CreatePersonDto, Person>();
            CreateMap<Animal, AnimalDto>();
            CreateMap<Treatment, TreatmentSummaryDto>();
        }
    }
}
