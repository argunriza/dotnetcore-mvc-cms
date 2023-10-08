using Microsoft.AspNetCore.Mvc;

namespace Cms.Web.Mvc.Doctor.Controllers
{
	public class AboutController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
