using StudentApplication.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentApplication.Controllers
{
    public class HomeController : Controller
    {
        //this is an example of setter injection
        private readonly ILogger logger;

        public HomeController(ILogger logger)
        {
            this.logger = logger;
        }

        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";
            logger.Log("welcome!");
            return View();
        }

        public ActionResult About()
        {
            logger.Log("wow!");
            return View();
        }
    }
}
