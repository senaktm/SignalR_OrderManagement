using Microsoft.AspNetCore.Mvc;

namespace SignalR_WebUI.Controllers
{
    public class StatisticsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
