using AutoMapper;
using EBS.DTO.DTOs.ProductReviewDtos;
using EBS.Entity.Entities;

namespace EBS.API.Mapping
{
    public class ProductReviewMapping : Profile
    {
        public ProductReviewMapping()
        {
            CreateMap<CreateProductReviewDto, ProductReview>().ReverseMap();
            CreateMap<UpdateProductReviewDto, ProductReview>().ReverseMap();
        }
    }
}
