using AutoMapper;
using EBS.DTO.DTOs.AgenceDtos;
using EBS.Entity.Entities;

namespace EBS.API.Mapping
{
    public class AgenceMapping : Profile
    {
        public AgenceMapping()
        {
            CreateMap<CreateAgenceDto, Agence>().ReverseMap();
            CreateMap<UpdateAgenceDto, Agence>().ReverseMap();
        }
    }
}
