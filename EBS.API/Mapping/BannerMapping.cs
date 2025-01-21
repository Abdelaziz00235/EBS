using AutoMapper;
using EBS.DTO.DTOs.BannerDtos;
using EBS.Entity.Entities;

namespace EBS.API.Mapping
{
    public class BannerMapping : Profile
    {
        public BannerMapping()
        {
            CreateMap<CreateBannerDto, Banner>().ReverseMap();
            CreateMap<UpdateBannerDto, Banner>().ReverseMap();
        }
    }
}
