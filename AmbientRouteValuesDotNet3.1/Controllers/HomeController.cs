using Microsoft.AspNetCore.Mvc;

namespace AmbientRouteValuesDotNet3_1.Controllers
{
    public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
