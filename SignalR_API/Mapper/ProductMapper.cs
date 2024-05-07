using AutoMapper;
using SignalR.DtoLayer.ProductDto;
using SignalR.EntityLayer.Concrete.Entities;

namespace SignalR_API.Mapper
{
    public class ProductMapper : Profile
    {
        public ProductMapper()
        {
            CreateMap<Product, ResultProductDto>().ReverseMap();
            CreateMap<Product, GetProductDto>().ReverseMap();
            CreateMap<Product, UpdateProductDto>().ReverseMap();
            CreateMap<Product, CreateProductDto>().ReverseMap();

            /*Whenever AutoMapper maps a Product instance to a ResultProductWithCategoryDto instance,
             it will use the CategoryName property of the Category object within the Product object
            to populate the CategoryName property of the ResultProductWithCategoryDto object.*/

            /*Product sınıfındaki Category özelliğinin içinde bulunan CategoryName özelliğini
              ResultProductWithCategoryDto sınıfındaki CategoryName özelliğine eşler.*/
            CreateMap<Product, ResultProductWithCategoryDto>()
                        .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.CategoryName))
                        .ReverseMap();
        }
    }
}
