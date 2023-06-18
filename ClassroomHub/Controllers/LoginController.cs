using Microsoft.AspNetCore.Mvc;

namespace ClassroomHub.Web.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return RedirectToAction("Index", "Activity");
        }
    }
}
