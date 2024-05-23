using SignalR.EntityLayer.Concrete.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.Abstract
{
    public interface IProductService : IGenericService<Product>
    {
        List<Product> TGetProductsWithCategories();
        public int TProductCount();
		public decimal TProductPriceAvg();
		public string TProductNamebyMaxPrice();
		public string TProductNamebyMinPrice();
		public decimal TProductPriceAvgbyCategory(string category);
	}
}
