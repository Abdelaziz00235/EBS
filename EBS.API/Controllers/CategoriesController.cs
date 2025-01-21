using AutoMapper;
using EBS.Business.Abstract;
using EBS.DTO.DTOs.CategoryDtos;
using EBS.Entity.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EBS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController(ICategoryService _categoryService,IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = _categoryService.BGetCategoryAll();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var values = _categoryService.TGetById(id);
            return Ok(values);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _categoryService.TDelete(id);
            return Ok("Suppression effectuer");
        }
        [HttpPost]
        public IActionResult Create(CreateCategoryDto createCategoryDto)
        {
            var newValue = _mapper.Map<Category>(createCategoryDto);
            _categoryService.TCreate(newValue);
            return Ok("Ajout effectuer");
        }
        [HttpPut]
        public IActionResult Update(UpdateCategoryDto updateCategoryDto)
        {
            var value = _mapper.Map<Category>(updateCategoryDto);
            _categoryService.TUpdate(value);
            return Ok("Mise a jour effectuer");
        }

        [HttpGet("GetCategoryCreatedByEmployee/{id}")]
        public IActionResult GetCategoryCreatedByEmployee(int id)
        {
            var values = _categoryService.BGetCategoryCreatedByEmployee(id);
            return Ok(values);
        }
         
        [HttpGet("GetActiveCategories")]
        public IActionResult GetActiveCategories()
        {
            var values = _categoryService.TGetFilteredList(x => x.IsActived == true);
            return Ok(values);
        }
    }
}
