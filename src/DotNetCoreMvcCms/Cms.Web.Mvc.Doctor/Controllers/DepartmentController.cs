using Microsoft.AspNetCore.Mvc;

namespace Cms.Web.Mvc.Doctor.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            return this.View();
        }

        public IActionResult Detail()
        {
            return this.View();
        }
    }
}
