using AutoMapper;
using SignalR.DtoLayer.AboutDto;
using SignalR.EntityLayer.Concrete.Entities;

namespace SignalR_API.Mapper
{
    public class AboutMapper : Profile
    {
        public AboutMapper() 
        { 
            CreateMap<About, ResultAboutDto>().ReverseMap();
            CreateMap<About, CreateAboutDto>().ReverseMap();
            CreateMap<About, GetAboutDto>().ReverseMap();
            CreateMap<About, UpdateAboutDto>().ReverseMap();

        }
    }
}
