using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;

namespace SignalR_API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CashBoxController : ControllerBase
	{
		private readonly ICashBoxService _cashBoxService;

		public CashBoxController(ICashBoxService cashBoxService)
		{
			_cashBoxService = cashBoxService;
		}
		[HttpGet]
		public IActionResult TotalCashBoxAmount()
		{
			return Ok(_cashBoxService.TTotalCashBoxAmount());
		}

	}
}
