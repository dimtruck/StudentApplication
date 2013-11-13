using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using StudentApplication;
using StudentApplication.Controllers;
using Domain.Repositories;
using Domain.Objects;
using Moq;
using StudentApplication.Services.Interfaces;
using NUnit.Framework;

namespace StudentApplication.Tests.Controllers
{
    [TestFixture]
    public class HomeControllerTest
    {
        private Mock<ILogger> logMock;
        private HomeController controller;

        [SetUp]
        public void Setup()
        {
            //Arrange
            logMock = new Mock<ILogger>();
            logMock.Setup(r => r.Log(It.IsAny<string>())).Verifiable("this fails");
            controller = new HomeController(logMock.Object);
        }

        [TearDown]
        public void Teardown()
        {
            logMock.Verify(f => f.Log(It.IsAny<String>()), Times.Once);
        }

        [Test]
        public void Index()
        {

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.AreEqual("Welcome to ASP.NET MVC!", result.ViewBag.Message);
        }

        [Test]
        public void About()
        {

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
