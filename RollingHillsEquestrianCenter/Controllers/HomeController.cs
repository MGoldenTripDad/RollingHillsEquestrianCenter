﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RollingHillsEquestrianCenter.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Home()
        {
            return View();
        }

        public ActionResult AboutUs()
        {
            return View();
        }

    }
}