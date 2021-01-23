using System;
using System.Collections.Generic;
using System.Text;
using AutomationFramework.Config;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Safari;

namespace AutomationFramework.Base
{
    /// <summary>
    /// This class must be inherited by the hooks in test framework
    /// </summary>
    public abstract class TestInitializeHook
    {

        
        public BrowserType Browser { get; set; }

        // public TestInitializeHook(BrowserType browser)
        // {
        //     //Browser = browser;
        // }
        public TestInitializeHook()
        {
            //Browser = browser;
        }
        public void InitializeSettings()
        {
            ConfigReader.SetFrameworkSettings();
            OpenBrowser(Settings.Browser);
            //OpenBrowser(GetBrowserOptions(Settings.Browser));
        }

        // private DriverOptions GetBrowserOptions(BrowserType browser)
        // {
        //     switch (browser)
        //     {
        //         case BrowserType.Internet_explorer:
        //             return new InternetExplorerOptions();
        //         case BrowserType.Chrome:
        //             return new ChromeOptions();
        //             
        //         case BrowserType.Firefox:
        //             return new FirefoxOptions();
        //         case BrowserType.Safari:
        //             return new SafariOptions();
        //         default:
        //             return new ChromeOptions();
        //     }
        // }

        private void OpenBrowser(BrowserType browserType)
        {
            switch (browserType)
            {
                case BrowserType.Internet_explorer:
                    break;
                case BrowserType.Chrome:
                    DriverContext.Driver = new ChromeDriver();
                    DriverContext.Browser = new Browser(DriverContext.Driver);
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
            DriverContext.Browser.GoToUrl(url);
        }

        
    }
}
