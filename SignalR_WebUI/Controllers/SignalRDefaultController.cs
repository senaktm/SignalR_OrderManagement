﻿using Microsoft.AspNetCore.Mvc;

namespace SignalR_WebUI.Controllers
{
    public class SignalRDefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
