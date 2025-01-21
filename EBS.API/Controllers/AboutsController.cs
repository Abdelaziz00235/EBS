﻿using AutoMapper;
using EBS.Business.Abstract;
using EBS.DTO.DTOs.AboutDtos;
using EBS.Entity.Entities;
using Microsoft.AspNetCore.Mvc;

namespace EBS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutsController(IAboutService _aboutService, IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = _aboutService.TGetList();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var values = _aboutService.TGetById(id);
            return Ok(values);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _aboutService.TDelete(id);
            return Ok("Suppression effectuer");
        }
        [HttpPost]
        public IActionResult Create(CreateAboutDto createAboutDto)
        {
            var newValue = _mapper.Map<About>(createAboutDto);
            _aboutService.TCreate(newValue);
            return Ok("Ajout effectuer");
        }
        [HttpPut]
        public IActionResult Update(UpdateAboutDto updateAboutDto)
        {
            var value = _mapper.Map<About>(updateAboutDto);
            _aboutService.TUpdate(value);
            return Ok("Mise a jour effectuer");
        }

        [HttpGet("GetAboutCreatedByEmployee/{id}")]
        public IActionResult GetAboutCreatedByEmployee(int id)
        {
            var values = _aboutService.BGetAboutCreatedByEmployee(id);
            return Ok(values); 
        }

    }
}