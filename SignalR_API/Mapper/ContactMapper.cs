using AutoMapper;
using SignalR.DtoLayer.ContactDto;
using SignalR.EntityLayer.Concrete.Entities;

namespace SignalR_API.Mapper
{
    public class ContactMapper : Profile
    {
        public ContactMapper() 
        { 
            CreateMap<Contact,ResultContactDto>().ReverseMap();
            CreateMap<Contact, GetContactDto>().ReverseMap();
            CreateMap<Contact, UpdateContactDto>().ReverseMap();
            CreateMap<Contact, CreateContactDto>().ReverseMap();
        }
    }
}
