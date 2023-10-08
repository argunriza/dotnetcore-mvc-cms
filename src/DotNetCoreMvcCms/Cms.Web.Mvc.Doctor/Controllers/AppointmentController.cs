using Microsoft.AspNetCore.Mvc;

namespace Cms.Web.Mvc.Doctor.Controllers
{
	public class AppointmentController : Controller
	{
		public IActionResult Index()
		{
			return this.View();
		}
	}
}
