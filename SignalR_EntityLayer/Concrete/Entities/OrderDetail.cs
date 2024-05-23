﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.EntityLayer.Concrete.Entities
{
	public class OrderDetail
	{
		public int OrderDetailID { get; set; }
		public int ProductID {  get; set; }
		public Product Product { get; set; }
		public int OrderProductCount {  get; set; }
		public decimal PeoductUnitPrice { get; set; }
		public decimal OrderTotalPrice {  get; set; }
		public int OrderID {  get; set; }
		public Order Order { get; set; }
	}

}
