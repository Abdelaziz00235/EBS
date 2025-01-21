using AutoMapper;
using EBS.DTO.DTOs.MessageDtos;
using EBS.Entity.Entities;

namespace EBS.API.Mapping
{
    public class MessageMapping : Profile
    {
        public MessageMapping()
        {
            CreateMap<CreateMessageDto, Message>().ReverseMap();
            CreateMap<UpdateMessageDto, Message>().ReverseMap();
        }
    }
}
