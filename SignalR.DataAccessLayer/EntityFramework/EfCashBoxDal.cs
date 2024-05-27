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
	public class EfCashBoxDal : GenericRepository<CashBox>, ICashBoxDal
	{
		public EfCashBoxDal(Context context) : base(context)
		{
		}

		public decimal TotalCashBoxAmount()
		{
			using var context = new Context();
			return context.CashBoxes.Select(x=>x.CashBoxTotalAmount).FirstOrDefault();
		}
	}
}
