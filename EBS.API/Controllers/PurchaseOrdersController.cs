using AutoMapper;
using EBS.Business.Abstract;
using EBS.DTO.DTOs.PurchaseOrderDtos;
using EBS.Entity.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EBS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseOrdersController(IPurchaseOrderService _PurchaseOrderService, IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = _PurchaseOrderService.BGetPurchaseOrderAll();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var values = _PurchaseOrderService.TGetById(id);
            return Ok(values);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _PurchaseOrderService.TDelete(id);
            return Ok("Suppression effectuer");
        }
        [HttpPost]
        public IActionResult Create(CreatePurchaseOrderDto createPurchaseOrderDto)
        {
            var newValue = _mapper.Map<PurchaseOrder>(createPurchaseOrderDto);
            _PurchaseOrderService.TCreate(newValue);
            return Ok("Ajout effectuer");
        }
        [HttpPut]
        public IActionResult Update(UpdatePurchaseOrderDto updatePurchaseOrderDto)
        {
            var value = _mapper.Map<PurchaseOrder>(updatePurchaseOrderDto);
            _PurchaseOrderService.TUpdate(value);
            return Ok("Mise a jour effectuer");
        }

        [HttpGet("GetPurchaseOrderValidatedByIdEmployee/{id}")]
        public IActionResult GetPurchaseOrderValidatedByIdEmployee(int id)
        {
            var values = _PurchaseOrderService.BGetPurchaseOrderValidatedByIdEmployee(id);
            return Ok(values);
        }

        [HttpGet("GetPurchaseOrderCreatedByEmployee/{id}")]
        public IActionResult GetPurchaseOrderCreatedByEmployee(int id)
        {
            var values = _PurchaseOrderService.BGetPurchaseOrderCreatedByEmployee(id);
            return Ok(values);
        }
    }
}
