using AutoMapper;
using SignalR.DtoLayer.FeatureDto;
using SignalR.EntityLayer.Concrete.Entities;

namespace SignalR_API.Mapper
{
    public class FeatureMapper : Profile
    {
        public FeatureMapper() 
        {
            CreateMap<Feature,ResultFeatureDto>().ReverseMap();
            CreateMap<Feature, GetFeatureDto>().ReverseMap();
            CreateMap<Feature, UpdateFeatureDto>().ReverseMap();
            CreateMap<Feature, CreateFeatureDto>().ReverseMap();
        }
    }
}
