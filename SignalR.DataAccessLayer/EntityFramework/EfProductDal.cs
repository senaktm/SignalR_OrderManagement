using Microsoft.EntityFrameworkCore;
using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DataAccessLayer.Repository;
using SignalR.EntityLayer.Concrete.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        

        public EfProductDal(Context context) : base(context)
        {
            
        }

        public List<Product> GetProductsWithCategories()
        {
            var context = new Context();
            var values = context.Products.Include(x=>x.Category).ToList();
            return values;
        }

		public int ProductCount()
		{
			using var context = new Context();
            return context.Products.Count();
		}

		public string ProductNamebyMaxPrice()
		{
			using var context = new Context();
			return context.Products.Where(x => x.ProductPrice == (context.Products.Max(y => y.ProductPrice)))
				.Select(z => z.ProductName).FirstOrDefault();
		}

		public string ProductNamebyMinPrice()
		{
			using var context = new Context();
			return context.Products.Where(x=>x.ProductPrice ==(context.Products.Min(y=>y.ProductPrice)))
				.Select(z => z.ProductName).FirstOrDefault();
		}

		public decimal ProductPriceAvg()
		{
			using var context = new Context();
			return context.Products.Average(x=>x.ProductPrice);
		}

		public decimal ProductPriceAvgbyCategory(String category)
		{
			using var context = new Context();
			return context.Products.Where(x => x.CategoryID == (context.Categories.Where(y => y.CategoryName == category).Select
			(z => z.CategoryID).FirstOrDefault())).Average(w=>w.ProductPrice);
		}
	}
}
