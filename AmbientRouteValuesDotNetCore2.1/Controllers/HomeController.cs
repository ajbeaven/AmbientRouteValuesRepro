using Microsoft.AspNetCore.Mvc;

namespace AmbientRouteValuesDotNetCore2_1.Controllers
{
    public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
