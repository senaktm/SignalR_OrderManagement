using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.ReservationDto;
using SignalR.EntityLayer.Concrete.Entities;

namespace SignalR_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationApiController : ControllerBase
    {
        private readonly IReservationService _reservationService;
        private readonly IMapper _mapper;

        public ReservationApiController(IReservationService reservationService, IMapper mapper)
        {
            _reservationService = reservationService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult ReservationList() 
        {
            var values = _mapper.Map<List<ResultReservationDto>>(_reservationService.TGetListAll());
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateReservation(CreateReservationDto createReservationDto)
        {
            _reservationService.TAdd( new Reservation() { 
                ReservationDate = createReservationDto.ReservationDate,
                ReservationEmail = createReservationDto.ReservationEmail,
                ReservationName = createReservationDto.ReservationName,
                ReservationPersonCount = createReservationDto.ReservationPersonCount,
                ReservationPhone = createReservationDto.ReservationPhone,
            });
            
            return Ok("Reservation eklendi");
        }

        [HttpDelete]
        public IActionResult DeleteReservation(int id)
        {
            var value = _reservationService.TGetByID(id);
            _reservationService.TDelete(value);
            return Ok("Reservation silindi");
        }

        [HttpPut]
        public IActionResult UpdateReservation(UpdateReservationDto updateReservationDto)
        {
            _reservationService.TUpdate( new Reservation()
            {
                ReservationID = updateReservationDto.ReservationID,
                ReservationDate = updateReservationDto.ReservationDate,
                ReservationEmail = updateReservationDto.ReservationEmail,
                ReservationName = updateReservationDto.ReservationName,
                ReservationPersonCount = updateReservationDto.ReservationPersonCount,
                ReservationPhone = updateReservationDto.ReservationPhone,
            });
           
            return Ok("Reservation güncellendi");
        }

        [HttpGet("{id}")]
        public IActionResult GetReservation(int id)
        {
            var value = _reservationService.TGetByID(id);
            return Ok(value);
        }
    }
}
