﻿using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace AutomationFramework.Base
{
    public abstract class BasePage : BaseClass
    {
        //public IWebDriver Driver { get; set; }

        protected BasePage()
        {
            // We can't set the driver here as we inherit from baseclass
            //Driver = DriverContext.Driver;
        }
    }
}
