using AutoMapper;
using EBS.DTO.DTOs.AboutDtos;
using EBS.Entity.Entities;

namespace EBS.API.Mapping
{
    public class AboutMapping : Profile
    {
        public AboutMapping() 
        {
            CreateMap<CreateAboutDto, About>().ReverseMap();
            CreateMap<UpdateAboutDto, About>().ReverseMap();
        }
    }
}
