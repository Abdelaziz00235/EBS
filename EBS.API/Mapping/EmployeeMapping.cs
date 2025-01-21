using AutoMapper;
using EBS.DTO.DTOs.EmployeeDtos;
using EBS.Entity.Entities;

namespace EBS.API.Mapping
{
    public class EmployeeMapping : Profile
    {
        public EmployeeMapping()
        {
            CreateMap<CreateEmployeeDto, Employee>().ReverseMap();
            CreateMap<UpdateEmployeeDto, Employee>().ReverseMap();
        }
    }
}
