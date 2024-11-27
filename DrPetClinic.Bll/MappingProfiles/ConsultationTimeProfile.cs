using AutoMapper;
using DrPetClinic.Bll.DTOs;
using DrPetClinic.Data.Entities;

namespace DrPetClinic.Bll.MappingProfiles
{
    public class ConsultationTimeProfile : Profile
    {
        public ConsultationTimeProfile()
        {
            CreateMap<ConsultationTime, ConsultationTimeDto>()
                .ForMember(dest => dest.Employee, opt => opt.MapFrom(src => src.Employee)); // Employee automatikus leképezése

            CreateMap<Employee, EmployeeSummaryDto>();
            CreateMap<CreateConsultationTimeDto, ConsultationTime>();
            CreateMap<ConsultationTimeDto, CreateConsultationTimeDto>().ReverseMap();
        }
    }
}
