using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment.PageObjects;
using Assignment.Utility;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace Assignment.TestMethods
{
    public class BecomePartner
    {
        private IWebDriver driver;
        private BecomePartnerPage _BecomePartnerPage;
        public BecomePartner()
        {
            driver = Browser.Driver;
            _BecomePartnerPage = new BecomePartnerPage(driver);
        }

        public void VerifyTypeOfPartners(Table table)
        {
            var expectedRowCount = table.RowCount;
            var partnersCollection=driver.FindElements(By.XPath(_BecomePartnerPage.PartnerRadio));
            var actualRowCount = partnersCollection.Count;
            bool found = false;
            if (actualRowCount == expectedRowCount)
            {
                foreach (var row in table.Rows)
                {
                    string value = ((string[])row.Values)[0];
                    for(int i=0;i< actualRowCount;i++)
                    {
                        if(value.Equals(partnersCollection[i].GetAttribute("id")))
                        {
                            found = true;
                            break;
                        }
                    }
                    if (found)
                        Console.WriteLine("Partner found : "+value);
                    else
                        Console.WriteLine("Partner not found : " + value);
                }
                
            }
            else
                throw new Exception("Count of type of partners not matched");
        }

        public void ClickGetDemo()
        {
            _BecomePartnerPage.DemoButtonRadio.Click();
        }

        public void SelectPartner(string partnerType)
        {
            var partnersCollection = driver.FindElements(By.XPath(_BecomePartnerPage.PartnerLabel));
            var actualRowCount = partnersCollection.Count;

            for (int i = 0; i < actualRowCount; i++)
            {
                if (partnersCollection[i].Text.Equals(partnerType))
                {
                    partnersCollection[i].Click();
                    break;
                }
            }

        }

        public void VerifyErrorMessage()
        {
            try
            {
                var actualErrorMessage = _BecomePartnerPage.ErrorMessage.Text;
                Assert.AreEqual("Please select a type of partner", actualErrorMessage, "Error message not matched");
            }
            catch (Exception)
            {
                throw new Exception("Error message not present");
            }
        }
    }

}
