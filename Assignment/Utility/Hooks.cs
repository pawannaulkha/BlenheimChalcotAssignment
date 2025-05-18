using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Assignment.Utility
{

    [Binding]
    public class Hooks
    {
        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            Browser.Initialize();
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            Browser.Driver.Quit();
        }


    }
}
