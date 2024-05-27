using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;

namespace SignalR_API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class OrderApiController : ControllerBase
	{
		private readonly IOrderService _orderService;

		public OrderApiController(IOrderService orderService)
		{
			_orderService = orderService;
		}
		[HttpGet]
		public IActionResult TotalOrderCount()
		{
			return Ok(_orderService.TTotalOrderCount());
		}
		[HttpGet("ActiveOrderCount")]
		public IActionResult ActiveOrderCount()
		{
			return Ok(_orderService.TActiveOrderCount());
		}
		[HttpGet("LastOrderPrice")]
		public IActionResult LastOrderPrice()
		{
			return Ok(_orderService.TLastOrderPrice());
		}

		[HttpGet("TodayTotalPrice")]
		public IActionResult TodayTotalPrice()
		{
			return Ok(_orderService.TTodayTotalPrice());
		}
		[HttpGet("PassiveOrderTableNumber")]
		public IActionResult PassiveOrderTableNumber()
		{
			return Ok(_orderService.TPassiveOrderTableNumber());
		}

	}
}
