using AutoMapper;
using EBS.DTO.DTOs.CategoryDtos;
using EBS.Entity.Entities;

namespace EBS.API.Mapping
{
    public class CategoryMapping : Profile
    {
        public CategoryMapping()
        {
            CreateMap<CreateCategoryDto, Category>().ReverseMap();
            CreateMap<UpdateCategoryDto, Category>().ReverseMap();
        }
    }
}
