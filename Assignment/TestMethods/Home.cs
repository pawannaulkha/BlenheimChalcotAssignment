using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment.PageObjects;
using Assignment.Utility;
using OpenQA.Selenium;

namespace Assignment.TestMethods
{
    public class Home
    {
        private IWebDriver driver;
        private HomePage _HomePage;
        public Home()
        {
            driver = Browser.Driver;
            _HomePage = new HomePage(driver);
        }

        public void ClickGetDemo()
        {
            _HomePage.HeaderGetDemoButton.Click();
        }

    }
}
