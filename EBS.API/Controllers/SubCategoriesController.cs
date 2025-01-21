using AutoMapper;
using EBS.Business.Abstract;
using EBS.DTO.DTOs.SubCategoryDtos;
using EBS.Entity.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EBS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubCategoriesController(ISubCategoryService _SubCategoryService, IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = _SubCategoryService.BGetSubCategoryAll();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var values = _SubCategoryService.TGetById(id);
            return Ok(values);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _SubCategoryService.TDelete(id);
            return Ok("Suppression effectuer");
        }
        [HttpPost]
        public IActionResult Create(CreateSubCategoryDto createSubCategoryDto)
        {
            var newValue = _mapper.Map<SubCategory>(createSubCategoryDto);
            _SubCategoryService.TCreate(newValue);
            return Ok("Ajout effectuer");
        }
        [HttpPut]
        public IActionResult Update(UpdateSubCategoryDto updateSubCategoryDto)
        {
            var value = _mapper.Map<SubCategory>(updateSubCategoryDto);
            _SubCategoryService.TUpdate(value);
            return Ok("Mise a jour effectuer");
        }

        [HttpGet("ShowOnHome/{id}")]
        public IActionResult ShowOnHome(int id)
        {
            _SubCategoryService.BShowOnHome(id);
            return Ok("Afficher a la page index");
        }
        [HttpGet("DontShowOnHome/{id}")]
        public IActionResult DontShowOnHome(int id)
        {
            _SubCategoryService.BDontShowOnHome(id);
            return Ok("Ne pas Afficher a la page index");
        }
        [HttpGet("GetActiveProducts")]
        public IActionResult GetActiveProducts()
        {
            var values = _SubCategoryService.TGetFilteredList(x => x.IsActived == true);
            return Ok(values);
        }


        [HttpGet("GetSubCategoryCreatedByEmployee/{id}")]
        public IActionResult GetSubCategoryCreatedByEmployee(int id)
        {
            var values = _SubCategoryService.BGetSubCategoryCreatedByEmployee(id);
            return Ok(values);
        }

    }
}
