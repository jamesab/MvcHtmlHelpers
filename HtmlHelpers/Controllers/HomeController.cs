using HtmlHelpers.RazorHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HtmlHelpers.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult FromApp_CodeFolder()
        {            

            return View();
        }

        public ActionResult FromController()
        {
            ViewBag.Helper = MyClassHelpers.RegularModal("From the Contorller. Oh yeah thats right!");

            return View();
        }
    }
}