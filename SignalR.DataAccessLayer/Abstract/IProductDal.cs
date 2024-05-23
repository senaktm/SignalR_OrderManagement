using SignalR.EntityLayer.Concrete.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccessLayer.Abstract
{
    public interface IProductDal : IGenericDal<Product>
    {
        List<Product> GetProductsWithCategories();
        public int ProductCount();
        public decimal ProductPriceAvg();
        public string ProductNamebyMaxPrice();
		public string ProductNamebyMinPrice();
        public decimal ProductPriceAvgbyCategory(string category);
	}
}
