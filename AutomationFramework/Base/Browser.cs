﻿using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace AutomationFramework.Base
{
    public class Browser
    {
        private IWebDriver _driver;

        public Browser(IWebDriver driver)
        {
            _driver = driver;
        }

        public BrowserType Type { get; set; }

        public void GoToUrl(string url)
        {
            DriverContext.Driver.Url = url;
        }


    }

    public enum BrowserType
    {
        Internet_explorer,
        Chrome,
        Firefox,
        Safari

    }
}
