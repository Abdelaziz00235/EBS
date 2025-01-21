using AutoMapper;
using EBS.DTO.DTOs.WitshListDtos;
using EBS.Entity.Entities;

namespace EBS.API.Mapping
{
    public class WitshListMapping : Profile
    {
        public WitshListMapping()
        {
            CreateMap<CreateWitshListDto, WitshList>().ReverseMap();
            CreateMap<UpdateWitshListDto, WitshList>().ReverseMap();
        }
    }
}
