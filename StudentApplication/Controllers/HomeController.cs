using Domain.Objects;
using Domain.Repositories;
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
        private readonly IRepository<Student> studentRepository;

        public HomeController(ILogger logger, IRepository<Student> studentRepository)
        {
            this.logger = logger;
            this.studentRepository = studentRepository;
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
