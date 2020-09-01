using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Please input your name to contact us.";

            return View();
        }

        public ActionResult ThankYou(string firstname, string lastname)
        {
            ViewBag.Welcome = $"Welcome, {firstname} {lastname}!";
            return View();
        }

        public ActionResult Hello()
        {
            return Content($"<h2>The current time is {DateTime.Now}</h2>");
        }
        public ActionResult GetTime()
        {
            return View();
        }
        public ActionResult Registration()
        {
            ViewBag.Message = "Register Here.";

            return View();
        }
    }
}