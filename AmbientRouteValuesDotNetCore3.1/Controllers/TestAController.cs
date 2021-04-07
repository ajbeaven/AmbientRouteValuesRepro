using Microsoft.AspNetCore.Mvc;

namespace AmbientRouteValuesDotNetCore3_1.Controllers
{
    public class TestAController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
