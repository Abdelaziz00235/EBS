using AutoMapper;
using EBS.DTO.DTOs.SupplierDtos;
using EBS.Entity.Entities;

namespace EBS.API.Mapping
{
    public class SupplierMapping : Profile
    {
        public SupplierMapping()
        {
            CreateMap<CreateSupplierDto, Supplier>().ReverseMap();
            CreateMap<UpdateSupplierDto, Supplier>().ReverseMap();
        }
    }
}
