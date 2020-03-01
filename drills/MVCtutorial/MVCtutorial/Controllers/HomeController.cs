using MVCtutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCtutorial.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            User user = new User();
            user.Id = 1;
            user.FirstName = "Jesse";
            user.LastName = "Johnson";
            user.Age = 32;
            return View(user);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            throw new Exception("Invalid page");

            return View();
        }

        public ActionResult Contact(int id=0) //can accept parameters, through the url .\Contact\5
        { 
            ViewBag.Message = id;

            return View();
        }
    }
}
//loging txt
// string text = "Hello";
// System.IO.File.WriteAllText(@"C:\Users\Kyla Kozole\Desktop\Repositories\c#.NET\MVCtutorial\log.txt", text);

// ViewBag.RandomNumber = num;

//Random rnd = new Random(10);
//int num = rnd.Next();

//if (num > 20000)
//{
//    return View("About"); //will remain on the home page but display the view.cshtml
//}

//return Content("hello");
//return Content(""); //returns nothing, can be helpful (when?)
//return RedirectToAction("Contact"); //redirect to Action (result) Contact()

//int number = 5;
//List<string> names = new List<string>()
//    {
//        "Jesse",
//        "Adam",
//        "Brett"
//    };