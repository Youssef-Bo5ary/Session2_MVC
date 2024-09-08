using Microsoft.AspNetCore.Mvc;

namespace Session2_MVC.Controllers
{
    public class MoviesController : Controller
    {


        public IActionResult GetMovie(int[] arr)
        {
            //Helper Method
            return Content($"Movie with Id ");
        }


        //public IActionResult GetMovie(int id)
        //{
        //    //Helper Method
        //    return Content($"Movie with Id : {id}");
        //}
        //Action Parameter Binding
        // 1. form  
        // 2.Segment (write the id in url)
        //3.Query String ( in url (id =10))
        //4.file

        //public string Index()
        //{
        //    return "Hello from Index";
        //}


        public IActionResult Index()
        {
            //===Action Result=======
            //ContentResult result = new ContentResult();
            //result.Content = "Hello again from Index page";
            //return result;
            //==== Helper Method ============
            return Content("Hello From Index bae", "text/html");//Content
        }
        //redirect result =  // a method goes to another method
        public IActionResult Test()
        { 
            //====== Action Result ==========
            ////when  call Test method he goes to index as a URL said
            //RedirectResult result = new RedirectResult("https://localhost:44314/Movies/Index");
            //return result;
            // ===== Helper Method ===============
           // return Redirect("https://localhost:44314/Movies/Index");

            //if I wanna make the URL Dynamic
         //   return RedirectToAction(nameof(Index));
            return RedirectToRoute(new {controller = "Movies" , action =  "Index"});

        }

    }
}
