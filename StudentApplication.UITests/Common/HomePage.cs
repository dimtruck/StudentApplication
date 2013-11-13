using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApplication.UITests.Common
{
    public class HomePage
    {
        private IWebDriver driver = null;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            if (!driver.Title.Equals("Student Application")) {
                throw new NotFoundException("This is not Home Page, current page" +
                                "is: " + driver.Url);
            }
        }

        public StudentPage viewAllStudents()
        {
            
            IWebElement student_list = driver.FindElement(By.LinkText("Students"));
            student_list.Click();
            return new StudentPage(driver);
        }
    }
}
