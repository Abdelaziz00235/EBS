using AutoMapper;
using EBS.Business.Abstract;
using EBS.DTO.DTOs.BasketDtos;
using EBS.Entity.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EBS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketsController(IBasketService _basketService,IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = _basketService.BGetBasketWithEmployeeProduct();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var values = _basketService.TGetById(id);
            return Ok(values);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _basketService.TDelete(id);
            return Ok("Suppression effectuer");
        }
        [HttpPost]
        public IActionResult Create(CreateBasketDto createBasketDto)
        {
            if (createBasketDto.Quantity <=0) {
                createBasketDto.Quantity = 1;
            }
            var newValue = _mapper.Map<Basket>(createBasketDto);
            _basketService.TCreate(newValue);
            return Ok("Ajout effectuer");
        }
        [HttpPut]
        public IActionResult Update(UpdateBasketDto updateBasketDto)
        {
            var value = _mapper.Map<Basket>(updateBasketDto);
            _basketService.TUpdate(value);
            return Ok("Mise a jour effectuer");
        }
    }
}
