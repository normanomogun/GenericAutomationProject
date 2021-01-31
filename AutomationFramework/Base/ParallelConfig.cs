using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Remote;

namespace AutomationFramework.Base
{
    public class ParallelConfig
    {
        public RemoteWebDriver Driver { get; set; }
        public BasePage CurrentPage { get; set; }   
    }
}
