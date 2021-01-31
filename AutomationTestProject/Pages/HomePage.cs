﻿using System;
using System.Collections.Generic;
using System.Text;
using AutomationFramework.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
//using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace AutomationTestProject.Pages
{
    public class HomePage: BasePage
    {
        public HomePage(ParallelConfig parallelConfig) : base(parallelConfig)
        {
        }

        public IWebElement lnkLogin => _parallelConfig.Driver.FindElement(By.Id("loginLink"));
        public IWebElement lnkEmployeeList => GetNavItem("Employee List");
        public IWebElement loggedInTitle => GetNavItem("Hello");
        public bool IsBrowserOnHomePage()
        {
            return true;
        }

        public LoginPage ClickLoginLink()
        {
          
            lnkLogin.Click();
            return new LoginPage(_parallelConfig);
        }

        public bool IsSuccessFullyLoggedIn()
        {
            return loggedInTitle.Displayed;

        }

        public EmployeeListPage ClickEmployeeListLink()
        {
            lnkEmployeeList.Click();
            return new EmployeeListPage(_parallelConfig);
        }

        private IWebElement GetNavItem(string navItemName)
        {
            IWebElement element = null;
            var navItems = _parallelConfig.Driver.FindElements(By.CssSelector(".navbar-collapse ul li"));
            foreach (var navItem in navItems)
            {
                var navItemTxt = navItem.Text;
                if (navItemTxt.Contains(navItemName))
                {
                    element = navItem;
                }
            }

            return element;
        }

       
    }
}
