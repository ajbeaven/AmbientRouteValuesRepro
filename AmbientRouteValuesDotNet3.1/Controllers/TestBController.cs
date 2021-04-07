using Microsoft.AspNetCore.Mvc;

namespace AmbientRouteValuesDotNet3_1.Controllers
{
    public class TestBController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
