using AutoMapper;
using EBS.API.Mapping;
using EBS.Business.Abstract;
using EBS.DTO.DTOs.ProductReviewDtos;
using EBS.Entity.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EBS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductReviewsController(IProductReviewService _ProductReviewService, IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = _ProductReviewService.BGetProductReviewAll();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var values = _ProductReviewService.TGetById(id);
            return Ok(values);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _ProductReviewService.TDelete(id);
            return Ok("Suppression effectuer");
        }
        [HttpPost]
        public IActionResult Create(CreateProductReviewDto createProductReviewDto)
        {
            var newValue = _mapper.Map<ProductReview>(createProductReviewDto);
            _ProductReviewService.TCreate(newValue);
            return Ok("Ajout effectuer");
        }
        [HttpPut]
        public IActionResult Update(UpdateProductReviewDto updateProductReviewDto)
        {
            var value = _mapper.Map<ProductReview>(updateProductReviewDto);
            _ProductReviewService.TUpdate(value);
            return Ok("Mise a jour effectuer");
        }
    }
}
