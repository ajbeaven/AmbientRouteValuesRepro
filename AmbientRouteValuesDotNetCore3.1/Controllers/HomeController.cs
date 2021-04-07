using Microsoft.AspNetCore.Mvc;

namespace AmbientRouteValuesDotNetCore3_1.Controllers
{
    public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
