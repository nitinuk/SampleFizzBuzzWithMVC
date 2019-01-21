using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleFizzBuzzChecker.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult CheckIsFizzorBuzz()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CheckIsFizzorBuzz(int i)
        {
            string result = "";
            if (i % 3 == 0)            
                result = "Fizz";            
            if( i%5 ==0)
                result += "Buzz";
            if (string.IsNullOrEmpty(result))
                result = "Provided number is not Fizz, Buzz or FizzBuzz";

            ViewBag.Result = result;
            return View();

           
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}