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
        private readonly IRepository<Course> courseRepo;

        public StudentController(IRepository<Student> studentRepo, IRepository<Course> courseRepo)
        {
            this.studentRepo = studentRepo;
            this.courseRepo = courseRepo;
        }

        //
        // GET: /Students/

        public ActionResult Index()
        {
            IQueryable <Student> studentList = this.studentRepo.ListAll();
            return View(studentList);
        }

        public ActionResult ListCourses()
        {
            var courseList = this.courseRepo.ListAll();
            return View(courseList);
        }


    }
}