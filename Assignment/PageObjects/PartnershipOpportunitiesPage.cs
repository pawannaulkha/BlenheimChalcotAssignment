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
   public class PartnershipOpportunitiesPage
    {
        public PartnershipOpportunitiesPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//h1[text()='Partnership Opportunities']")]
        public IWebElement PartnershipOpportunitiesHeader;

    }
}
