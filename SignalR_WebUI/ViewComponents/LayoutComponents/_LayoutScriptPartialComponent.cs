using Microsoft.AspNetCore.Mvc;

namespace SignalR_WebUI.ViewComponents.LayoutComponents
{
	public class _LayoutScriptPartialComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
