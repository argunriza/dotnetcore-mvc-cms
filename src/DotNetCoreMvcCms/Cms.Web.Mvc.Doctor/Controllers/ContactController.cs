using Microsoft.AspNetCore.Mvc;

namespace Cms.Web.Mvc.Doctor.Controllers
{
	public class ContactController : Controller
	{
		public IActionResult Index()
		{
			return this.View();
		}
	}
}
