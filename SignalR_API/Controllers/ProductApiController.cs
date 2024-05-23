using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.ProductDto;
using SignalR.EntityLayer.Concrete.Entities;

namespace SignalR_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductApiController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductApiController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult ProductList()
        {
            var values = _mapper.Map<List<ResultProductDto>>(_productService.TGetListAll());
            return Ok(values);
        }
		[HttpGet("ProductCount")]
		public IActionResult ProductCount()
		{
			
			return Ok(_productService.TProductCount());
		}
		[HttpGet("ProductNamebyMaxPrice")]
		public IActionResult ProductNamebyMaxPrice()
		{

			return Ok(_productService.TProductNamebyMaxPrice());
		}
		[HttpGet("ProductNamebyMinPrice")]
		public IActionResult ProductNamebyMinPrice()
		{

			return Ok(_productService.TProductNamebyMinPrice());
		}
		[HttpGet("ProductPriceAvg")]
		public IActionResult ProductPriceAvg()
		{

			return Ok(_productService.TProductPriceAvg());
		}
		[HttpGet("ProductPriceAvgbyCategory")]
		public IActionResult ProductPriceAvgbyCategory(string category)
		{

			return Ok(_productService.TProductPriceAvgbyCategory(category));
		}
		[HttpPost]
        public IActionResult CreateProduct(CreateProductDto createProductDto)
        {
            _productService.TAdd( new Product()
            {
                ProductDescription = createProductDto.ProductDescription,
                ProductName = createProductDto.ProductName,
                ProductImageUrl = createProductDto.ProductImageUrl,
                ProductPrice = createProductDto.ProductPrice,
                ProductStatus = createProductDto.ProductStatus,
                CategoryID = createProductDto.CategoryID,
            });
            
            return Ok("Product eklendi");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var value = _productService.TGetByID(id);
            _productService.TDelete(value);
            return Ok("Product silindi");
        }

        [HttpPut]
        public IActionResult UpdateProduct(UpdateProductDto updateProductDto)
        {
            _productService.TUpdate(new Product()
            {
                ProductID = updateProductDto.ProductID,
                ProductDescription = updateProductDto.ProductDescription,
                ProductName = updateProductDto.ProductName,
                ProductImageUrl = updateProductDto.ProductImageUrl,
                ProductPrice = updateProductDto.ProductPrice,
                ProductStatus = updateProductDto.ProductStatus,
                 CategoryID = updateProductDto.CategoryID,
            });
          
            return Ok("Product güncellendi");
        }

        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            var value = _productService.TGetByID(id);
            return Ok(value);
        }

        [HttpGet("ProductListWithCategory")]
        public IActionResult ProductListWithCategory(int id)
        {
            var values = _mapper.Map<List<ResultProductWithCategoryDto>>(_productService.TGetProductsWithCategories());
            return Ok(values);
        }
    }
}
