using AutoMapper;
using SignalR.DtoLayer.ReservationDto;
using SignalR.EntityLayer.Concrete.Entities;

namespace SignalR_API.Mapper
{
    public class ReservationMapper : Profile
    {
        public ReservationMapper() 
        { 
            CreateMap<Reservation,ResultReservationDto>().ReverseMap();
            CreateMap<Reservation, GetReservationDto>().ReverseMap();
            CreateMap<Reservation, UpdateReservationDto>().ReverseMap();
            CreateMap<Reservation, CreateReservationDto>().ReverseMap();
        }
    }
}
