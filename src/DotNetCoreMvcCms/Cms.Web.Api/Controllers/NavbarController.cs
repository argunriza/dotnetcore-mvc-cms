using Cms.Data.Models.Entities;
using Cms.Services.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cms.Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NavbarController : ControllerBase
    {
        private readonly IDataRepository<NavbarEntity> _navbarService;

        public NavbarController(IDataRepository<NavbarEntity> navbar)
        {
            this._navbarService = navbar;
        }

        [HttpGet]
        public IEnumerable<NavbarEntity> GetAll()
        {
            var doctors = this._navbarService.GetAll();

            return doctors;
        }
    }
}
