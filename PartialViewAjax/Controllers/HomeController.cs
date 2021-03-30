using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PartialViewAjax.Models;

namespace PartialViewAjax.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}

		public IActionResult PartialLoad()
		{
			var list = new List<string>() { "Load1", "Load2", "Load3" };

			// PartialView を呼ぶこと
			return PartialView("Partial", list);
		}

		public IActionResult PartialButton()
		{
			var list = new List<string>() { "Button1", "Button2", "Button3" };

			// PartialView を呼ぶこと
			return PartialView("Partial", list);
		}
	}
}
