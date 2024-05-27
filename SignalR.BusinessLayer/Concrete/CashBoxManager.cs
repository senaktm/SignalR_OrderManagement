using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Abstract;
using SignalR.EntityLayer.Concrete.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.Concrete
{
	public class CashBoxManager : ICashBoxService
	{
		private readonly ICashBoxDal _cashBoxDal;

		public CashBoxManager(ICashBoxDal cashBoxDal)
		{
			_cashBoxDal = cashBoxDal;
		}

		public void TAdd(CashBox entity)
		{
			throw new NotImplementedException();
		}

		public void TDelete(CashBox entity)
		{
			throw new NotImplementedException();
		}

		public CashBox TGetByID(int id)
		{
			throw new NotImplementedException();
		}

		public List<CashBox> TGetListAll()
		{
			throw new NotImplementedException();
		}

		public decimal TTotalCashBoxAmount()
		{
			return _cashBoxDal.TotalCashBoxAmount();
		}

		public void TUpdate(CashBox entity)
		{
			throw new NotImplementedException();
		}
	}
}
