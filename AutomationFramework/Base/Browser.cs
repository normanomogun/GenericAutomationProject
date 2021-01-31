using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace AutomationFramework.Base
{
    public class Browser
    {
        private DriverContext _drivercontext;

        public Browser(DriverContext driverContext)
        {
            _drivercontext = driverContext;
        }

        public BrowserType Type { get; set; }


    }

    public enum BrowserType
    {
        Internet_explorer,
        Chrome,
        Firefox,
        Safari

    }
}
