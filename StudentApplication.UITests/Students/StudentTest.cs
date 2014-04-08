using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using StudentApplication.UITests.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApplication.UITests.Students
{
    [TestFixture]
    public class StudentTest
    {
        private IWebDriver driver;
        //            new InternetExplorerDriver(
        //                new InternetExplorerOptions() { 
        //                    IntroduceInstabilityByIgnoringProtectedModeSettings = true });


        [TestFixtureSetUp]
        public void SetUp()
        {
            driver = new ChromeDriver(@"C:\Users\Administrator\chromedriver_win32_2.8");
            driver.Navigate().GoToUrl("http://localhost:8080/");
        }

        [TestFixtureTearDown]
        public void TearDown()
        {
            //driver.Close();
        }

        [Test]
        public void testStudentList()
        {
            //arrange
            HomePage page = new HomePage(driver);

            //act
            StudentPage studentPage = page.viewAllStudents();

            //assert
            Assert.AreEqual("this is my other title", driver.Title);

        }
    }
}
