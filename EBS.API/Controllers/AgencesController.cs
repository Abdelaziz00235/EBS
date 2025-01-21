using AutoMapper;
using EBS.Business.Abstract;
using EBS.DTO.DTOs.AgenceDtos;
using EBS.Entity.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace EBS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgencesController(IAgenceService _agenceService, IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = _agenceService.BGetAgenceList();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var values = _agenceService.TGetById(id);
            return Ok(values);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        { 
            _agenceService.TDelete(id);
            return Ok("Suppression effectuer");    
        }
        [HttpPost]
        public IActionResult Create(CreateAgenceDto createAgenceDto)
        {
            var newValue = _mapper.Map<Agence>(createAgenceDto);
            _agenceService.TCreate(newValue);
            return Ok("Ajout effectuer");
        }
        [HttpPut]
        public IActionResult Update(UpdateAgenceDto updateAgenceDto) 
        {
            var value = _mapper.Map<Agence>(updateAgenceDto);
            _agenceService.TUpdate(value);
            return Ok("Mise a jour effectuer");
        }

        [HttpGet("GetActiveAgences")]
        public IActionResult GetActiveAgences()
        {
            var values = _agenceService.TGetFilteredList(x => x.IsActived == true);
            return Ok(values);
        }
    }
}
