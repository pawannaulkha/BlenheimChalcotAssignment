using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace Utilities.CommonUtility
{
    public static class Browser
    {
        public static IWebDriver Driver;
        public static void Initialize()
        {
            var chromeConfig = new ChromeConfig();
            var matchingVersion=chromeConfig.GetMatchingBrowserVersion();
            new DriverManager().SetUpDriver(chromeConfig, matchingVersion);
            var Driver = new ChromeDriver();
            //string driverPath = @"C:\SeleniumDriver";
            //ChromeOptions options = new ChromeOptions();
            //options.AddArguments("chrome.switches", "--disable-extensions");
            //Driver = new ChromeDriver(driverPath, options, TimeSpan.FromSeconds(90));
        }

        public static void NavigateToUrl(string url = "")
        {
            Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60);
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            if (string.IsNullOrEmpty(url))
                Driver.Navigate().GoToUrl(url);
            else
                Driver.Navigate().GoToUrl(url);
            Driver.Manage().Window.Maximize();
        }

        public static void SwitchToWindow(string windowName)
        {
            foreach (var handle in Driver.WindowHandles)
            {
                Driver.SwitchTo().Window(handle);
                if (Driver.Title.Contains(windowName))
                    break;
            }

        }
    }
}
