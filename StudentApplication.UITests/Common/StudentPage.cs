using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApplication.UITests.Common
{
    public class StudentPage
    {
        private IWebDriver driver = null;

        public StudentPage(IWebDriver driver)
        {
            this.driver = driver;
            if (!driver.Title.Equals("this is my other title"))
            {
                throw new NotFoundException("This is not Student Page, current page" +
                                "is: " + driver.Url);
            }
        }

    }
}
