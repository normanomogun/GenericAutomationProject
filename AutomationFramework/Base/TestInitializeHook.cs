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
            OpenBrowser(Settings.Browser, Settings.RunType);
            //OpenBrowser(GetBrowserOptions(Settings.Browser));
        }


        private void OpenBrowser(BrowserType browserType, string runType)
        {
            switch (runType.ToLower())
            {
                case "grid":
                    switch (browserType)
                    {
                        case BrowserType.Internet_explorer:
                            break;
                        case BrowserType.Chrome:
                            ChromeOptions chOptions = new ChromeOptions();
                            chOptions.AddArgument("start-maximized");
                            _parallelConfig.Driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), chOptions); 
                            break;
                        case BrowserType.Firefox:
                            break;
                        case BrowserType.Safari:
                            break;
                        default:
                            throw new ArgumentOutOfRangeException(nameof(browserType), browserType, null);
                    }

                    break;
                case "local":
                    switch (browserType)
                    {
                        case BrowserType.Internet_explorer:
                            break;
                        case BrowserType.Chrome:
                            ChromeOptions chOptions = new ChromeOptions();
                            chOptions.AddArgument("start-maximized");
                            _parallelConfig.Driver = new ChromeDriver(chOptions); 

                            break;
                        case BrowserType.Firefox:
                            break;
                        case BrowserType.Safari:
                            break;
                        default:
                            throw new ArgumentOutOfRangeException(nameof(browserType), browserType, null);
                    }
                    break;
                default:
                    throw new Exception($"Check spelling for run type setting: '{runType}'! it should be either 'grid' or 'local'");
            }
        }

        public virtual void NavigateToSite(string url)
        {
           _parallelConfig.Driver.Navigate().GoToUrl(url);
        }

        
    }
}
