﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SignalRDemo.Controllers
{
    public class ClientController : Controller
    {
        // GET: Client
        public ActionResult ChannelA()
        {
            return View();
        }

        public ActionResult ChannelB()
        {
            return View();
        }
    }
}