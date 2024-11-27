using AutoMapper;
using DrPetClinic.Bll.DTOs;
using DrPetClinic.Data.Entities;

namespace DrPetClinic.Bll.MappingProfiles
{
    public class AnimalProfile : Profile
    {
        public AnimalProfile()
        {
            CreateMap<Animal, AnimalDto>()
                .ForMember(dest => dest.Owners, opt => opt.MapFrom(src => src.Owners))
                .ForMember(dest => dest.Treatments, opt => opt.MapFrom(src => src.Treatments));

            CreateMap<CreateAnimalDto, Animal>();
            CreateMap<Person, OwnerDto>();
            CreateMap<Treatment, TreatmentSummaryDto>();
            CreateMap<AnimalDto, Animal>();
        }
    }
}
