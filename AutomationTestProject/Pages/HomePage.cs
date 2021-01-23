using System;
using System.Collections.Generic;
using System.Text;
using AutomationFramework.Base;
using OpenQA.Selenium;

namespace AutomationTestProject.Pages
{
    public class HomePage: BasePage
    {
        public IWebElement lnkLogin => Driver.FindElement(By.Id("loginLink"));
        public IWebElement lnkEmployeeList => GetNavItem("Employee List");
        public IWebElement loggedInTitle => GetNavItem("Hello");
        public bool IsBrowserOnHomePage()
        {
            return true;
        }

        public LoginPage ClickLoginLink()
        {
            lnkLogin.Click();
            return GetInstance<LoginPage>();
        }

        public bool IsSuccessFullyLoggedIn()
        {
            return loggedInTitle.Displayed;

        }

        public EmployeeListPage ClickEmployeeListLink()
        {
            lnkEmployeeList.Click();
            return GetInstance<EmployeeListPage>();
        }

        private IWebElement GetNavItem(string navItemName)
        {
            IWebElement element = null;
            var navItems = Driver.FindElements(By.CssSelector(".navbar-collapse ul li"));
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
