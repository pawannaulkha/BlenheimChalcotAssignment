using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Assignment.PageObjects;
using Assignment.Utility;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Assignment.TestMethods
{
    public class PartnershipOpportunities
    {
        private IWebDriver driver;
        private PartnershipOpportunitiesPage _PartnershipOpportunitiesPage;
        public PartnershipOpportunities()
        {
            driver = Browser.Driver;
            _PartnershipOpportunitiesPage = new PartnershipOpportunitiesPage(driver);
        }

        public void VaildatePartnershipOpportunitiesHeader()
        {
            _PartnershipOpportunitiesPage.PartnershipOpportunitiesHeader.Click();
            string actualText = _PartnershipOpportunitiesPage.PartnershipOpportunitiesHeader.Text;
            Console.WriteLine("PartnershipOpportunities : " + actualText);
            Assert.AreEqual("Partnership Opportunities", actualText,  "PartnershipOpportunities Header not present"); 
        }

    }
}
