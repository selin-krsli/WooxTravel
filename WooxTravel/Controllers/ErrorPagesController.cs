﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WooxTravel.Controllers
{
    public class ErrorPagesController : Controller
    {
        public ActionResult Page404()
        {
            return View();
        }
    }
}