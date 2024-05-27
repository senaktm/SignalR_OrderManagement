using SignalR.EntityLayer.Concrete.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccessLayer.Abstract
{
	public interface ICashBoxDal : IGenericDal<CashBox>
	{
		decimal TotalCashBoxAmount();
	}
}
