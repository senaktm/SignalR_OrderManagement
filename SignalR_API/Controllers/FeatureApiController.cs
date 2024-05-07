using AutoMapper;
using AutoMapper.Features;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.FeatureDto;
using SignalR.EntityLayer.Concrete.Entities;

namespace SignalR_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeatureApiController : ControllerBase
    {
        private readonly IFeatureService _featureService;
        private readonly IMapper _mapper;

        public FeatureApiController(IFeatureService featureService, IMapper mapper)
        {
            _featureService = featureService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult FeatureList()
        {
            var values = _mapper.Map<List<ResultFeatureDto>>(_featureService.TGetListAll());
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateFeature(CreateFeatureDto createFeatureDto)
        {
            _featureService.TAdd( new Feature() { 
            FeatureDescription1 = createFeatureDto.FeatureDescription1,
            FeatureDescription2 = createFeatureDto.FeatureDescription2,
            FeatureDescription3 = createFeatureDto.FeatureDescription3,
            FeatureTitle1 = createFeatureDto.FeatureTitle1,
            FeatureTitle2 = createFeatureDto.FeatureTitle2,
            FeatureTitle3 = createFeatureDto.FeatureTitle3
            });
         
            return Ok("Feature eklendi");
        }

        [HttpDelete]
        public IActionResult DeleteFeature(int id) 
        {
            var value = _featureService.TGetByID(id);
            _featureService.TDelete(value);
            return Ok("Feature silindi");
        }

        [HttpPut]
        public IActionResult UpdateFeature(UpdateFeatureDto updateFeatureDto)
        {
            _featureService.TUpdate(new Feature()
            {
                FeatureID = updateFeatureDto.FeatureID,
                FeatureDescription1 = updateFeatureDto.FeatureDescription1,
                FeatureDescription2 = updateFeatureDto.FeatureDescription2,
                FeatureDescription3 = updateFeatureDto.FeatureDescription3,
                FeatureTitle1 = updateFeatureDto.FeatureTitle1,
                FeatureTitle2 = updateFeatureDto.FeatureTitle2,
                FeatureTitle3 = updateFeatureDto.FeatureTitle3
            });
           
            return Ok("Feature güncellendi");

        }
        [HttpGet("GetFeature")]
        public IActionResult GetFeature(int id) 
        {
            var value = _featureService.TGetByID(id);
            return Ok(value);
        }
    }
}
