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
    public class StudentController : Controller
    {
        public ILogger logger { get; set; }
        private readonly IRepository<Student> studentRepo;

        public StudentController(IRepository<Student> studentRepo)
        {
            this.studentRepo = studentRepo;
        }

        //
        // GET: /Students/

        public ActionResult Index()
        {
            IQueryable <Student> studentList = this.studentRepo.ListAll();
            ViewBag.Title = "this is my title";
            ViewData["title"] = "this is my other title";
            return View(studentList);
        }

        //public ActionResult ListCourses()
        //{
        //    var courseList = this.courseRepo.ListAll();
        //    return View(courseList);
        //}


    }
}