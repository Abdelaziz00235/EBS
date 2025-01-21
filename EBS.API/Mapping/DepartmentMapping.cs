using AutoMapper;
using EBS.DTO.DTOs.DepartmentDtos;
using EBS.Entity.Entities;

namespace EBS.API.Mapping
{
    public class DepartmentMapping : Profile
    {
        public DepartmentMapping()
        {
            CreateMap<CreateDepartmentDto, Department>().ReverseMap();
            CreateMap<UpdateDepartmentDto, Department>().ReverseMap();
        }
    }
}
