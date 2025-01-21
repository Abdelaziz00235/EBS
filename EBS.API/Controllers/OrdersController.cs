using AutoMapper;
using EBS.Business.Abstract;
using EBS.DTO.DTOs.OrderDtos;
using EBS.Entity.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EBS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController(IOrderService _orderService,IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = _orderService.BGetOrderAll();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var values = _orderService.TGetById(id);
            return Ok(values);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _orderService.TDelete(id);
            return Ok("Suppression effectuer");
        }
        [HttpPost]
        public IActionResult Create(CreateOrderDto createOrderDto)
        {
            var newValue = _mapper.Map<Order>(createOrderDto);
            _orderService.TCreate(newValue);
            return Ok("Ajout effectuer");
        }
        [HttpPut]
        public IActionResult Update(UpdateOrderDto updateOrderDto)
        {
            var value = _mapper.Map<Order>(updateOrderDto);
            _orderService.TUpdate(value);
            return Ok("Mise a jour effectuer");
        }

        [HttpGet("GetOrdersByEmployeeId/{id}")]
        public IActionResult GetOrdersByEmployeeId(int id) 
        {
            var values = _orderService.BGetOrderEmployeeId(id);
            
            return Ok(values);

            //var values = _orderService.TGetFilteredList(x=>x.EmployeeId == id);
            //var mappedValues = _mapper.Map<List<ReslutOrderDto>>(values);
            //return Ok(mappedValues);
        }
        
        [HttpGet("GetOrderValidatedByIdEmployeeId/{id}")]
        public IActionResult GetOrderValidatedByIdEmployeeId(int id)
        {
            var values = _orderService.BGetOrderValidatedByIdEmployeeId(id);
            return Ok(values);
        }
    }
}
