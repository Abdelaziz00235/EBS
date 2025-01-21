using AutoMapper;
using EBS.DTO.DTOs.SubCategoryDtos;
using EBS.Entity.Entities;

namespace EBS.API.Mapping
{
    public class SubCategoryMapping : Profile
    {
        public SubCategoryMapping()
        {
            CreateMap<CreateSubCategoryDto,SubCategory>().ReverseMap(); 
            CreateMap<UpdateSubCategoryDto,SubCategory>().ReverseMap(); 
        }
    }
}
