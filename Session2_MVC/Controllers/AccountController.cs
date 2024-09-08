using Microsoft.AspNetCore.Mvc;

namespace Session2_MVC.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Registor()
        {
            return View();
        }
    }
}
