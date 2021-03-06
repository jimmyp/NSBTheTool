﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Messages;
using NServiceBus;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBus _bus;

        public HomeController(IBus bus)
        {
            if (bus == null) throw new ArgumentNullException("bus");
            _bus = bus;
        }

        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SendCommand()
        {
            _bus.Send(new SomeCommand(){ Id = new Guid("5DF5B0BE-07B9-44DB-80F6-783FD6315CE9")});

            return View("Index");
        }
    }
}
