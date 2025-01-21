using AutoMapper;
using EBS.Entity.Entities;
using EBS.WebUI.DTOs.RoleDtos;

namespace EBS.WebUI.Mappings
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<EmployeeRole, ResultRoleDto>().ReverseMap();
            CreateMap<EmployeeRole, CreateRoleDto>().ReverseMap();
            CreateMap<EmployeeRole, UpdateRoleDto>().ReverseMap();
            
        }
    }
}
