using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using SeleniumExtras.PageObjects;

namespace Assignment.PageObjects
{
   public class HomePage
    {
        public HomePage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        
        [FindsBy(How = How.XPath, Using = "//div[@class='header-cta']//a[text()='Get a demo']")]
        public IWebElement HeaderGetDemoButton;

    }
}
