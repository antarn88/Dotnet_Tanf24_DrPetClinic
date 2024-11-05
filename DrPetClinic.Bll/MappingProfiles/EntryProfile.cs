using AutoMapper;
using DrPetClinic.Bll.DTOs;
using DrPetClinic.Data.Entities;

namespace DrPetClinic.Bll.MappingProfiles
{
    public class EntryProfile : Profile
    {
        public EntryProfile()
        {
            CreateMap<Entry, EntrySummaryDto>();
            CreateMap<Entry, EntryDetailsDto>()
                .ForMember(dest => dest.History, opt => opt.MapFrom(src => src.History))
                .ForMember(dest => dest.Treatment, opt => opt.MapFrom(src => src.Treatment));

            CreateMap<CreateEntryDto, Entry>();
        }
    }
}
