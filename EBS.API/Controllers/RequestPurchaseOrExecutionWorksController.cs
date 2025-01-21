using AutoMapper;
using EBS.Business.Abstract;
using EBS.DTO.DTOs.RequestPurchaseOrExecutionWorkDtos;
using EBS.Entity.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EBS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestPurchaseOrExecutionWorksController(IRequestPurchaseOrExecutionWorkService _RequestPurchaseOrExecutionWork, IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = _RequestPurchaseOrExecutionWork.BGetRequestPurchaseOrExecutionWorkAll();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var values = _RequestPurchaseOrExecutionWork.TGetById(id);
            return Ok(values);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _RequestPurchaseOrExecutionWork.TDelete(id);
            return Ok("Suppression effectuer");
        }
        [HttpPost]
        public IActionResult Create(CreateRequestPurchaseOrExecutionWorkDto createRequestPurchaseOrExecutionWorkDto)
        {
            var newValue = _mapper.Map<RequestPurchaseOrExecutionWork>(createRequestPurchaseOrExecutionWorkDto);
            _RequestPurchaseOrExecutionWork.TCreate(newValue);
            return Ok("Ajout effectuer");
        }
        [HttpPut]
        public IActionResult Update(UpdateRequestPurchaseOrExecutionWorkDto updateRequestPurchaseOrExecutionWorkDto)
        {
            var value = _mapper.Map<RequestPurchaseOrExecutionWork>(updateRequestPurchaseOrExecutionWorkDto);
            _RequestPurchaseOrExecutionWork.TUpdate(value);
            return Ok("Mise a jour effectuer");
        }

        [HttpGet("GetPurchaseOrExecutionWorkValidatedByIdEmployee/{id}")]
        public IActionResult GetPurchaseOrExecutionWorkValidatedByIdEmployee(int id)
        {
            var values = _RequestPurchaseOrExecutionWork.BGetPurchaseOrExecutionWorkValidatedByIdEmployee(id);
            return Ok(values);
        }

        [HttpGet("GetPurchaseOrExecutionWorkCreatedByEmployee/{id}")]
        public IActionResult GetPurchaseOrExecutionWorkCreatedByEmployee(int id)
        {
            var values = _RequestPurchaseOrExecutionWork.BGetPurchaseOrExecutionWorkCreatedByEmployee(id);
            return Ok(values);
        }
    }
    
}
