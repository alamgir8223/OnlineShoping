﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ecommerce.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult ManWear()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult WomanWear()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Children()
        {
            ViewBag.Message = "Your contact page.";

            return View();

        }
    }
}
