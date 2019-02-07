using Microsoft.AspNetCore.Mvc;

namespace Ldv.PersonalSite.Controllers
{
    public class SinglePageController : Controller
    {
        [HttpGet]
        public IActionResult Index() => View();
    }
}
