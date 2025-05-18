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
   public class BecomePartnerPage
    {
        public BecomePartnerPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        public static string Title = "Become A Partner | Liberis";

        [FindsBy(How = How.XPath, Using = "//div[@class='radio_container']//following-sibling::a[text()='Get a demo']")]
        public IWebElement DemoButtonRadio;

        [FindsBy(How = How.ClassName, Using = "ph-error-inner")]
        public IWebElement ErrorMessage;

        public string PartnerRadio = "//div[@class='radio_container']//input[@type='radio']";

        public string PartnerLabel = "//div[@class='radio_container']//label";   
    }
}
