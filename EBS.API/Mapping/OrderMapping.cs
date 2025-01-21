using AutoMapper;
using EBS.DTO.DTOs.OrderDtos;
using EBS.Entity.Entities;

namespace EBS.API.Mapping
{
    public class OrderMapping : Profile
    {
        public OrderMapping()
        {
            CreateMap<CreateOrderDto,Order>().ReverseMap();
            CreateMap<UpdateOrderDto,Order>().ReverseMap();
        }
    }
}
