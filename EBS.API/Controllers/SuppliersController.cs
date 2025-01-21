using AutoMapper;
using EBS.Business.Abstract;
using EBS.DTO.DTOs.SupplierDtos;
using EBS.Entity.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EBS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuppliersController(ISupplierService _supplierService, IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = _supplierService.BGetSupplierAll();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var values = _supplierService.TGetById(id);
            return Ok(values);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _supplierService.TDelete(id);
            return Ok("Suppression effectuer");
        }
        [HttpPost]
        public IActionResult Create(CreateSupplierDto createSupplierDto)
        {
            var newValue = _mapper.Map<Supplier>(createSupplierDto);
            _supplierService.TCreate(newValue);
            return Ok("Ajout effectuer");
        }
        [HttpPut]
        public IActionResult Update(UpdateSupplierDto updateSupplierDto)
        {
            var value = _mapper.Map<Supplier>(updateSupplierDto);
            _supplierService.TUpdate(value);
            return Ok("Mise a jour effectuer");
        }



        [HttpGet("GetSupplierCreatedByEmployee/{id}")]
        public IActionResult GetSupplierCreatedByEmployee(int id)
        {
            var values = _supplierService.BGetSupplierCreatedByEmployee(id);
            return Ok(values);
        }
    }
}
