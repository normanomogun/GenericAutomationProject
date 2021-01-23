﻿using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace AutomationFramework.Base
{
    public static class DriverContext
    {
        private static IWebDriver _driver;

        public static IWebDriver Driver
        {
            get
            {
                return _driver;
            }
            set
            {
                _driver = value;
            }
        }

        public static Browser Browser { get; set; } //Not sure why this is here 
    }
}
