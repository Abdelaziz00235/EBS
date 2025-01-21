using AutoMapper;
using EBS.DTO.DTOs.ContactDtos;
using EBS.Entity.Entities;

namespace EBS.API.Mapping
{
    public class ContactMapping : Profile
    {
        public ContactMapping()
        {
            CreateMap<CreateContactDto,Contact>().ReverseMap();
            CreateMap<UpdateContactDto,Contact>().ReverseMap();

        }
    }
}
