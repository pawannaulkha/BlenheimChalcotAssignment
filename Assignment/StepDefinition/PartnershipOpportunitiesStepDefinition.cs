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
using Assignment.PageObjects;

namespace Assignment.StepDefinitions
{
    [Binding]
    public class PartnershipOpportunitiesStepDefinition
    {
        private PartnershipOpportunities _PartnershipOpportunities;
        public PartnershipOpportunitiesStepDefinition()
        {
            _PartnershipOpportunities = new PartnershipOpportunities();
        }


       

    }
}
