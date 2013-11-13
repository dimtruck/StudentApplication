using System;
using NUnit.Framework;
using Moq;
using StudentApplication.Controllers;
using Domain.Objects;
using Domain.Repositories;
using System.Web.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace StudentApplication.Tests.Controllers
{
    [TestFixture]
    public class StudentControllerTest
    {
        [Test]
        public void TestListCourses()
        {
            //arrange
            IQueryable<Course> list = new List<Course>() { new Course() }.AsQueryable();
            Mock<IRepository<Student>> studentRepo = new Mock<IRepository<Student>>();
            Mock<IRepository<Course>> courseRepo = new Mock<IRepository<Course>>();
            courseRepo.Setup(t => t.ListAll()).Returns(list).Verifiable();
            var studentController = new StudentController(studentRepo.Object, courseRepo.Object);

            //act
            ViewResult result = studentController.ListCourses() as ViewResult;

            //assert
            Assert.IsNotNull(result);
            Assert.AreEqual(list,result.Model);
        }

        [Test]
        public void TestIndex()
        {
            //arrange
            IQueryable<Student> list = new List<Student>() { new Student() }.AsQueryable();
            Mock<IRepository<Student>> studentRepo = new Mock<IRepository<Student>>();
            studentRepo.Setup(t => t.ListAll()).Returns(list).Verifiable();
            Mock<IRepository<Course>> courseRepo = new Mock<IRepository<Course>>();
            var studentController = new StudentController(studentRepo.Object, courseRepo.Object);

            //act
            ViewResult result = studentController.Index() as ViewResult;

            //assert
            Assert.IsNotNull(result);
            Assert.AreEqual(list, result.Model);
        }
    }
}
