using Microsoft.AspNetCore.Mvc;

namespace Session2_MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()// Master Page
        {
            //  return View("All Movies");//will go to view All Movies
            return View();
        }

        public IActionResult AboutUs()
        {
            
            return View();
        }
        public IActionResult Privacy()
        {

            return View();
        }
        public IActionResult ContactUs()
        {

            return View();
        }

    }
}
