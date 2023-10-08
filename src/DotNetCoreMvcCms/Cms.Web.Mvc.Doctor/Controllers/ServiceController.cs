using Microsoft.AspNetCore.Mvc;

namespace Cms.Web.Mvc.Doctor.Controllers
{
	public class ServiceController : Controller
	{
		public IActionResult Index()
		{
			return this.View();
		}
	}
}
