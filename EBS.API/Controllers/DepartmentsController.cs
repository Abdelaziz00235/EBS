using AutoMapper;
using EBS.Business.Abstract;
using EBS.DTO.DTOs.DepartmentDtos;
using EBS.Entity.Entities;
using Microsoft.AspNetCore.Mvc;

namespace EBS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController(IDepartmentService _departmentService, IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = _departmentService.BGetDepartmentAll();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var values = _departmentService.TGetById(id);
            return Ok(values);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _departmentService.TDelete(id);
            return Ok("Suppression effectuer");
        }
        [HttpPost]
        public IActionResult Create(CreateDepartmentDto createDepartmentDto)
        {
            var newValue = _mapper.Map<Department>(createDepartmentDto);
            _departmentService.TCreate(newValue);
            return Ok("Ajout effectuer");
        }
        [HttpPut]
        public IActionResult Update(UpdateDepartmentDto updateDepartmentDto)
        {
            var value = _mapper.Map<Department>(updateDepartmentDto);
            _departmentService.TUpdate(value);
            return Ok("Mise a jour effectuer");
        }
        [HttpGet("GetActiveDepartments")]
        public IActionResult GetActiveDepartments()
        {
            var values = _departmentService.TGetFilteredList(x => x.IsActived == true);
            return Ok(values);
        }
    }
}
