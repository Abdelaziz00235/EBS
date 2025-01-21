using AutoMapper;
using EBS.DTO.DTOs.BrandDtos;
using EBS.Entity.Entities;

namespace EBS.API.Mapping
{
    public class BrandMapping : Profile
    {
        public BrandMapping()
        {
            CreateMap<CreateBrandDto,Brand>().ReverseMap();
            CreateMap<UpdateBrandDto,Brand>().ReverseMap();
        }
    }
}
