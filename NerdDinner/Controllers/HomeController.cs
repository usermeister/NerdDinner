using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NerdDinner.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Message"] = "Welcome to ASP.NET MVC! NerdDinner example.";
            ViewData["TestData"] = this.Url.ToString();

            return View();
        }

        public ActionResult About()
        {
            return View();

            
        }
    }
}
