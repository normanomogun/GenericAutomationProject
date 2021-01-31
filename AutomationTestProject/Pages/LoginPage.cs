using System;
using System.Collections.Generic;
using System.Text;
using AutomationFramework.Base;
using OpenQA.Selenium;

namespace AutomationTestProject.Pages
{
    public class LoginPage : BasePage
    {
        public LoginPage(ParallelConfig parallelConfig) : base(parallelConfig)
        {
        }

        public IWebElement txtUserName => _parallelConfig.Driver.FindElement(By.Id("UserName"));
        public IWebElement txtPassword => _parallelConfig.Driver.FindElement(By.Id("Password"));
       
        public IWebElement btnLogin => _parallelConfig.Driver.FindElement(By.CssSelector("input.btn"));
        // public IWebElement lnkEmployeeList => GetNavItem("Employee List");
        

        public void EnterLoginDetails(string username, string password)
        {
            txtUserName.SendKeys(username);
            txtPassword.SendKeys(password);
           
        }

        

        

        // private IWebElement GetNavItem(string navItemName)
        // {
        //     IWebElement element = null;
        //     var navItems = Driver.FindElements(By.CssSelector(".navbar-collapse ul li"));
        //     foreach (var navItem in navItems)
        //     {
        //         var navItemTxt = navItem.Text;
        //         if (navItemTxt.Contains(navItemName))
        //         {
        //             element = navItem;
        //         }
        //     }
        //
        //     return element;
        // }

        public HomePage ClickSubmitButton()
        {
            btnLogin.Submit();
            return new HomePage(_parallelConfig);
        }

        
    }
}
