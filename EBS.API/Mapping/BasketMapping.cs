using AutoMapper;
using EBS.DTO.DTOs.BasketDtos;
using EBS.Entity.Entities;

namespace EBS.API.Mapping
{
    public class BasketMapping : Profile
    {
        public BasketMapping()
        {
            CreateMap<CreateBasketDto, Basket>().ReverseMap();
            CreateMap<UpdateBasketDto, Basket>().ReverseMap();
        }
    }
}
