using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SKL_MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var list = new List<string>() { "SKL","Insuraance","Member","Ebill" };
            return View(list); 
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