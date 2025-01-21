using AutoMapper;
using EBS.Business.Abstract;
using EBS.DTO.DTOs.BrandDtos;
using EBS.Entity.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EBS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController(IBrandService _brandService, IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = _brandService.BGetBrandAll();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var values = _brandService.TGetById(id);
            return Ok(values);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _brandService.TDelete(id);
            return Ok("Suppression effectuer");
        }
        [HttpPost]
        public IActionResult Create(CreateBrandDto createBrandDto)
        {
            var newValue = _mapper.Map<Brand>(createBrandDto);
            _brandService.TCreate(newValue);
            return Ok("Ajout effectuer");
        }
        [HttpPut]
        public IActionResult Update(UpdateBrandDto updateBrandDto)
        {
            var value = _mapper.Map<Brand>(updateBrandDto);
            _brandService.TUpdate(value);
            return Ok("Mise a jour effectuer");
        }

        [HttpGet("GetBrandCreatedByEmployee/{id}")]
        public IActionResult GetBrandCreatedByEmployee(int id)
        {
            var values = _brandService.BGetBrandCreatedByEmployee(id);
            return Ok(values);
        }
    }
}
