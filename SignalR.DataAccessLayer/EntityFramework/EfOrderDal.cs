using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DataAccessLayer.Repository;
using SignalR.EntityLayer.Concrete.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccessLayer.EntityFramework
{
	public class EfOrderDal : GenericRepository<Order>, IOrderDal
	{
		public EfOrderDal(Context context) : base(context)
		{
		}

		public int TotalOrderCount()
		{
			using var context = new Context();
			return context.Orders.Count();
		}
		public int ActiveOrderCount()
		{
			using var context = new Context();
			return context.Orders.Where(x=>x.isActive==true).Count();
		}
		public decimal LastOrderPrice()
		{
			using var context = new Context();
			return context.Orders.OrderByDescending(x=>x.OrderID).Take(1).Select(y=>y.OrderTotalPrice).FirstOrDefault();
		}
	}
}
