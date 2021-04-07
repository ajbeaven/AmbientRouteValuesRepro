using Microsoft.AspNetCore.Mvc;

namespace AmbientRouteValuesDotNetCore2_1.Controllers
{
    public class TestAController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
