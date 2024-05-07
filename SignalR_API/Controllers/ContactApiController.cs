using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.ContactDto;
using SignalR.EntityLayer.Concrete.Entities;

namespace SignalR_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactApiController : ControllerBase
    {
        private readonly IContactService _contactService;
        private readonly IMapper _mapper;

        public ContactApiController(IContactService contactService, IMapper mapper)
        {
            _contactService = contactService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult ContactList()
        {
            var values = _mapper.Map<List<ResultContactDto>>(_contactService.TGetListAll());
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateContact(CreateContactDto createContactDto)
        {
            _contactService.TAdd( new Contact() 
            {
                FooterDescription = createContactDto.FooterDescription,
                FooterPhone = createContactDto.FooterPhone,
                FootertEmail = createContactDto.FootertEmail,
                FooterLocation = createContactDto.FooterLocation
            });
            
            return Ok("Contact kaydedildi");
        }

        [HttpDelete]
        public IActionResult DeleteContact(int id) 
        {
            var value = _contactService.TGetByID(id);
            _contactService.TDelete(value);
            return Ok("Contact silindi");
        }

        [HttpPut]
        public IActionResult UpdateContact(UpdateContactDto updateContactDto) 
        {
            _contactService.TUpdate(new Contact()
            {
                ContactID = updateContactDto.ContactID,
                FooterDescription = updateContactDto.FooterDescription,
                FooterPhone = updateContactDto.FooterPhone,
                FootertEmail = updateContactDto.FootertEmail,
                FooterLocation = updateContactDto.FooterLocation
            });
            
            return Ok("Contact güncellendi");
        }

        [HttpGet("GetContact")]
        public IActionResult GetContact(int id)
        {
            var value = _contactService.TGetByID(id);
            return Ok(value);
        }
    }
}
