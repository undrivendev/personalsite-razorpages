using Microsoft.AspNetCore.Mvc;

namespace Ldv.PersonalSite.Controllers
{
    [Route("Error")]
    public class ErrorController : Controller
    {

        [Route("404")]
        public IActionResult ErrorNotFound()
        {
            ViewBag.HideFooter = true;
            return View();
        }

        [Route("500")]
        public IActionResult ErrorException()
        {
            ViewBag.HideFooter = true;
            return View();
        }
    
    }
}
