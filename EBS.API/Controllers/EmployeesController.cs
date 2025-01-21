using AutoMapper;
using EBS.Business.Abstract;
using EBS.DTO.DTOs.EmployeeDtos;
using EBS.Entity.Entities;
using Microsoft.AspNetCore.Mvc;

namespace EBS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController(IEmployeeService _employeeService,IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = _employeeService.BGetEmployeeWithAgenceDepartment();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var values = _employeeService.TGetById(id);
            return Ok(values);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _employeeService.TDelete(id);
            return Ok("Suppression effectuer");
        }
        [HttpPost]
        public IActionResult Create(CreateEmployeeDto createEmployeeDto)
        {
            var newValue = _mapper.Map<Employee>(createEmployeeDto);
            _employeeService.TCreate(newValue);
            return Ok("Ajout effectuer");
        }
        [HttpPut]
        public IActionResult Update(UpdateEmployeeDto updateEmployeeDto)
        {
            var value = _mapper.Map<Employee>(updateEmployeeDto);
            _employeeService.TUpdate(value);
            return Ok("Mise a jour effectuer");
        }
    }
}
