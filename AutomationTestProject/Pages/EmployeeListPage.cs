using System;
using System.Collections.Generic;
using System.Text;
using AutomationFramework.Base;
using Dynamitey;
using OpenQA.Selenium;

namespace AutomationTestProject.Pages
{
    public class EmployeeListPage : BasePage
    {
        public IWebElement CreateNewButton => Driver.FindElement(By.CssSelector(".btn.btn-primary"));
        public EmployeeListPage() : base()
        {
        }

        public CreateEmployeePage ClickCreateNewButton()
        {
            CreateNewButton.Click();
            return GetInstance<CreateEmployeePage>();
        }
    }
}
