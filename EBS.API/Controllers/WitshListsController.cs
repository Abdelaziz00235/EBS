using AutoMapper;
using EBS.Business.Abstract;
using EBS.DTO.DTOs.WitshListDtos;
using EBS.Entity.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EBS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WitshListsController(IWitshListService WitshListService,IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = WitshListService.BGetWitshListAll();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var values = WitshListService.TGetById(id);
            return Ok(values);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            WitshListService.TDelete(id);
            return Ok("Suppression effectuer");
        }
        [HttpPost]
        public IActionResult Create(CreateWitshListDto createWitshListDto)
        {
            var newValue = _mapper.Map<WitshList>(createWitshListDto);
            WitshListService.TCreate(newValue);
            return Ok("Ajout effectuer");
        }
        [HttpPut]
        public IActionResult Update(UpdateWitshListDto updateWitshListDto)
        {
            var value = _mapper.Map<WitshList>(updateWitshListDto);
            WitshListService.TUpdate(value);
            return Ok("Mise a jour effectuer");
        }
    }
}
