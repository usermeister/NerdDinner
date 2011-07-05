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
            ViewData["TestData"] = "Time of Http request: " + this.Url.RequestContext.HttpContext.Timestamp.ToString();

            return View();
        }

        public ActionResult About()
        {
            return View();

            
        }
    }
}
