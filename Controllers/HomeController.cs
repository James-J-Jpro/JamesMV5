﻿using JamesScioMVC5.ActionFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JamesScioMVC5.Controllers
{
    [LogActionFilter]
    public class HomeController : Controller
    {
        public ActionResult Index(/*string dataFromUC*/)
        {
            var dataReceived = RouteData.Values;
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