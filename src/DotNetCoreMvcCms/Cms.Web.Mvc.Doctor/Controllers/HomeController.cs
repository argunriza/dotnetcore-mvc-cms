using Cms.Data.Models.Entities;
using Cms.Web.Mvc.Doctor.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Cms.Web.Mvc.Doctor.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly HttpClient _httpClient;

        private readonly string _apiNavbar = "https://localhost:7078/api/Navbar";

        public HomeController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ActionResult> Index()
        {
            var model = await _httpClient.GetFromJsonAsync<List<NavbarEntity>>(_apiNavbar);

            return View(model);
        }
    }
}