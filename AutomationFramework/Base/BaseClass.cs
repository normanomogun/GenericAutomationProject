using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;


namespace AutomationFramework.Base
{
    public class BaseClass : Steps // TODO: Need to find another way. Should not be inheriting from steps
    {

        // public BasePage CurrentPage NO LONGER NEEDED AS STATIC
        // {
        //     get => ScenarioContext.Get<BasePage>("currentpage");
        //     set => ScenarioContext.Set(value, "currentpage");
        // }

        public ParallelConfig _parallelConfig;

        public BaseClass(ParallelConfig parallelConfig)
        {
            _parallelConfig = parallelConfig;
        }

        public IWebDriver Driver { get; set; }

        /// <summary>
        /// Creates a generic instance of a page
        /// </summary>
        /// <typeparam name="TPage"></typeparam>
        /// <returns>Any class which is a basepage</returns>
        public TPage GetInstance<TPage>() where TPage : BasePage, new()
        {
            TPage pageInstance = new TPage()
            {
                //Driver = DriverContext.Driver // initialised here when you create a new page 
                Driver = _parallelConfig.Driver // initialised here when you create a new page 
            };
            return pageInstance;
        }


        /// <summary>
        /// This is to ensure that the page is returned 
        /// </summary>
        /// <typeparam name="TPage"></typeparam>
        /// <returns></returns>
        public TPage As<TPage>() where TPage : BasePage
        {
            return (TPage)this;
        }

        public WebDriverWait BaseWebDriverWait(int timeMilliseconds)
        {
            var webdriverWait = new WebDriverWait(Driver, TimeSpan.FromMilliseconds(timeMilliseconds));
            webdriverWait.IgnoreExceptionTypes(
                typeof(StaleElementReferenceException), 
                typeof(NoSuchElementException),
                typeof(ElementNotVisibleException));
            return webdriverWait;
        }
    }
}
