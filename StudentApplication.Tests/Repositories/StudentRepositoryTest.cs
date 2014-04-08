using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain.Repositories;
using Domain.Objects;
using System.Linq;

namespace StudentApplication.Tests.Repositories
{
    /// <summary>
    /// Summary description for StudentRepositoryTest
    /// </summary>
    [TestClass]
    public class StudentRepositoryTest
    {

        [TestMethod]
        public void TestNumberOfStudentsReturned()
        {
            IRepository<Student> studentRepository = new StudentRepository();
            Assert.AreEqual(2, studentRepository.ListAll().Count());
        }

        //[TestMethod]
        //public void TestNumberOfCoursesReturned()
        //{
        //    IRepository<Course> courseRepo = new CourseRepository();
        //    Assert.AreEqual(1, courseRepo.ListAll().Count());
        //}
    }
}
