﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.SocialMediaDto;
using SignalR.EntityLayer.Concrete.Entities;

namespace SignalR_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediaApiController : ControllerBase
    {
        private readonly ISocialMediaService _socialMediaService;
        private readonly IMapper _mapper;

        public SocialMediaApiController(ISocialMediaService socialMediaService, IMapper mapper)
        {
            _socialMediaService = socialMediaService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult SocialMediaList()
        {
            var values = _mapper.Map<List<ResultSocialMediaDto>>(_socialMediaService.TGetListAll());
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateSocialMedia(CreateSocialMediaDto createSocialMediaDto)
        {
            _socialMediaService.TAdd( new SocialMedia()
            {
                SocialMediaIcon = createSocialMediaDto.SocialMediaIcon,
                SocialMediaTitle = createSocialMediaDto.SocialMediaTitle,
                SocialMediaUrl = createSocialMediaDto.SocialMediaUrl,
                
            });

           
            return Ok("SocialMedia eklendi");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteSocialMedia(int id)
        {
            var value = _socialMediaService.TGetByID(id);
            _socialMediaService.TDelete(value);
            return Ok("SocialMedia silindi");
        }

        [HttpPut]
        public IActionResult UpdateSocialMedia(UpdateSocialMediaDto updateSocialMediaDto)
        {
            _socialMediaService.TUpdate( new SocialMedia()
            {
                SocialMediaID = updateSocialMediaDto.SocialMediaID,
                SocialMediaIcon = updateSocialMediaDto.SocialMediaIcon,
                SocialMediaTitle = updateSocialMediaDto.SocialMediaTitle,
                SocialMediaUrl = updateSocialMediaDto.SocialMediaUrl,

            });

           
            return Ok("SocialMedia güncellendi");
        }

        [HttpGet("{id}")]
        public IActionResult GetSocialMedia(int id)
        {
            var value = _socialMediaService.TGetByID(id);
            return Ok(value);
        }
    }
}
