using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace AutomationFramework.Base
{
    public class DriverContext
    {
        // private IWebDriver _driver;
        //
        // public IWebDriver Driver
        // {
        //     get
        //     {
        //         return _driver;
        //     }
        //     set
        //     {
        //         _driver = value;
        //     }
        // }

        private ParallelConfig _parallelConfig;

        public DriverContext(ParallelConfig parallelConfig)
        {
            _parallelConfig = parallelConfig;
        }


        public void GoToUrl(string url)
        {
            _parallelConfig.Driver.Url = url;
        }

        public static Browser Browser { get; set; } //Not sure why this is here 
    }
}
