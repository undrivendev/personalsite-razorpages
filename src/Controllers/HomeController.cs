using Microsoft.AspNetCore.Mvc;

namespace Ldv.PersonalSite.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index() => View();
    }
}
