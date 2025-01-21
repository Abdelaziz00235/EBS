using AutoMapper;
using EBS.DTO.DTOs.ProductDtos;
using EBS.Entity.Entities;

namespace EBS.API.Mapping
{
    public class ProductMapping : Profile
    {
        public ProductMapping()
        {
            CreateMap<CreateProductDto, Product>().ReverseMap();
            CreateMap<UpdateProductDto, Product>().ReverseMap();
        }
    }
}
