using AutoMapper;
using SignalR.DtoLayer.DiscountDto;
using SignalR.EntityLayer.Concrete.Entities;

namespace SignalR_API.Mapper
{
    public class DiscountMapper : Profile
    {
        public DiscountMapper() 
        {
            CreateMap<Discount,ResultDiscountDto>().ReverseMap();
            CreateMap<Discount, GetDiscountDto>().ReverseMap();
            CreateMap<Discount, UpdateDiscountDto>().ReverseMap();
            CreateMap<Discount, CreateDiscountDto>().ReverseMap();
        }
    }
}
