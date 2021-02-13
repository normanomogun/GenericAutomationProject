using System;
using System.Collections.Generic;
using System.Text;
using AutomationFramework.Config;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Safari;

namespace AutomationFramework.Base
{
    /// <summary>
    /// This class must be inherited by the hooks in test framework
    /// </summary>
    public class TestInitializeHook
    {
        private ParallelConfig _parallelConfig;

        protected TestInitializeHook(ParallelConfig parallelConfig)
        {
            _parallelConfig = parallelConfig;
        }

        public BrowserType Browser { get; set; }

        
        public void InitializeSettings()
        {
            ConfigReader.SetFrameworkSettings();
            OpenBrowser(Settings.Browser);
            //OpenBrowser(GetBrowserOptions(Settings.Browser));
        }


        private void OpenBrowser(BrowserType browserType)
        {
            switch (browserType)
            {
                case BrowserType.Internet_explorer:
                    break;
                case BrowserType.Chrome:
                   // DriverContext.Driver = new ChromeDriver();
                    //DriverContext.Browser = new Browser(DriverContext.Driver);
                   ChromeOptions chOptions = new ChromeOptions();
                   //chOptions.AddAdditionalCapability("chrome",CapabilityType.BrowserName);
                   
                   _parallelConfig.Driver = new ChromeDriver(); //This is what works at the minute
                   //_parallelConfig.Driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"),chOptions); works on grid so create a switch for it
                   
                   break;
                case BrowserType.Firefox:
                    break;
                case BrowserType.Safari:
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(browserType), browserType, null);
            }
        }

        public virtual void NavigateToSite(string url)
        {
           //_parallelConfig.Driver.GoToUrl(url);
           _parallelConfig.Driver.Navigate().GoToUrl(url);
        }

        
    }
}
