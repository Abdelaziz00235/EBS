using AutoMapper;
using EBS.DTO.DTOs.PurchaseOrderDtos;
using EBS.Entity.Entities;

namespace EBS.API.Mapping
{
    public class PurchaseOrderMapping : Profile
    {
        public PurchaseOrderMapping()
        {
            CreateMap<CreatePurchaseOrderDto, PurchaseOrder>().ReverseMap();
            CreateMap<UpdatePurchaseOrderDto, PurchaseOrder>().ReverseMap();
        }
    }
}
