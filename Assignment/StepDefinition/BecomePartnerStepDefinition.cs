using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment.TestMethods;
using Assignment.Utility;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Assignment.StepDefinition
{
    [Binding]
    public class BecomePartnerStepDefinition
    {
        private BecomePartner _BecomePartner;
        public BecomePartnerStepDefinition()
        {
            _BecomePartner = new BecomePartner();
        }


        [StepDefinition(@"User verified below partners on Partner Selection page")]
        public void UserVerifiedBelowPartnersOnPartnerSelectionPage(Table table)
        {
            _BecomePartner.VerifyTypeOfPartners(table);
        }

        [StepDefinition(@"User clicked Get a Demo button by selecting (.*) parter")]
        public void WhenUserClickedGetADemoButtonBySelectingParter(string partnerType)
        {
            _BecomePartner.SelectPartner(partnerType);
            _BecomePartner.ClickGetDemo();
        }

        [StepDefinition(@"User clicked Get a Demo button without selecting partner")]
        public void WhenUserClickedGetADemoButtonWithoutSelectingPartner()
        {
            _BecomePartner.ClickGetDemo();
        }

        [StepDefinition(@"User validate the error message")]
        public void ThenUserValidateTheErrorMessage()
        {
            _BecomePartner.VerifyErrorMessage();
        }

        
    }
}
