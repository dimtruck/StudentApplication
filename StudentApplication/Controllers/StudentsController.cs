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
    public class StudentsController : Controller
    {
        public ILogger logger { get; set; }
        private readonly IRepository<Student> repository;

        public StudentsController(IRepository<Student> repository)
        {
            this.repository = repository;
        }

        //
        // GET: /Students/

        public ActionResult Index()
        {
            IQueryable <Student> studentList = this.repository.ListAll();
            return View(studentList);
        }

    }
}