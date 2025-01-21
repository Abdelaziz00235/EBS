using AutoMapper;
using EBS.DTO.DTOs.RequestPurchaseOrExecutionWorkDtos;
using EBS.Entity.Entities;

namespace EBS.API.Mapping
{
    public class RequestPurchaseOrExecutionWorkMapping : Profile
    {
        public RequestPurchaseOrExecutionWorkMapping()
        {
            CreateMap<CreateRequestPurchaseOrExecutionWorkDto,RequestPurchaseOrExecutionWork>().ReverseMap();
            CreateMap<UpdateRequestPurchaseOrExecutionWorkDto,RequestPurchaseOrExecutionWork>().ReverseMap();
        }
    }
}
