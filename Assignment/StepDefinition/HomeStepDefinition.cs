using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment.TestMethods;
using Assignment.Utility;
using TechTalk.SpecFlow;
using System.Configuration;
using NUnit.Framework;

namespace Assignment.StepDefinitions
{
    [Binding]
    public class HomeStepDefinition
    {
        private Home _Home;
        private PartnershipOpportunities _PartnershipOpportunities;
        public HomeStepDefinition()
        {
            _Home = new Home();
            _PartnershipOpportunities = new PartnershipOpportunities();
        }


        [StepDefinition(@"User launch liberis application")]
        public void UserLaunchLiberisApplication()
        {
            Browser.NavigateToUrl(ConfigurationManager.AppSettings["URL"]);
        }

        [StepDefinition(@"User open Get a Demo page")]
        public void GivenUserOpenGetADemoPage()
        {
            _Home.ClickGetDemo();
        }


        [StepDefinition(@"User successfully navigates to (.*) page")]
        public void UserSuccessfullyNavigatesToPage(string expectedPageTitle)
        {
            Assert.IsTrue(Browser.VerifyTitleOfPage(expectedPageTitle), "Title of the page not matched");
            _PartnershipOpportunities.VaildatePartnershipOpportunitiesHeader();
        }



    }
}
