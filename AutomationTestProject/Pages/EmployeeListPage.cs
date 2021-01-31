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
        public EmployeeListPage(ParallelConfig parallelConfig) : base(parallelConfig)
        {
        }
        public IWebElement CreateNewButton => _parallelConfig.Driver.FindElement(By.CssSelector(".btn.btn-primary"));
       

        public CreateEmployeePage ClickCreateNewButton()
        {
            CreateNewButton.Click();
            return new CreateEmployeePage(_parallelConfig);
        }

       
    }
}
