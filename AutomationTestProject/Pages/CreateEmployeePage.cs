using System;
using System.Collections.Generic;
using System.Text;
using AutomationFramework.Base;
using AutomationFramework.Extensions;
using OpenQA.Selenium;

namespace AutomationTestProject.Pages
{
    public class CreateEmployeePage : BasePage
    {
        //private ParallelConfig _parallelConfig;
        public CreateEmployeePage(ParallelConfig parallelConfig) : base(parallelConfig)
        {
            
        }

        //public IWebElement NameField => _parallelConfig.Driver.FindElement(By.Id("Name"));
        // public IWebElement SalaryField => _parallelConfig.Driver.FindElement(By.Id("Salary"));
        // public IWebElement DurationField => _parallelConfig.Driver.FindElement(By.Id("DurationWorked"));
        //public IWebElement GradeField => _parallelConfig.Driver.FindElement(By.Id("Grade"));
        // public IWebElement EmailField => _parallelConfig.Driver.FindElement(By.Id("Email"));
        // public IWebElement CreateBtn => _parallelConfig.Driver.FindElement(By.CssSelector(".btn.btn-default"));
        //public IWebElement NameField => _parallelConfig.Driver.FindElementById("Names");
        public IWebElement NameField => _parallelConfig.Driver.FindById("Names");
        public IWebElement SalaryField => _parallelConfig.Driver.FindById("Salary");
        public IWebElement DurationField => _parallelConfig.Driver.FindById("DurationWorked");
        public IWebElement GradeField => _parallelConfig.Driver.FindById("Grade");
        public IWebElement EmailField => _parallelConfig.Driver.FindById("Email");
        public IWebElement CreateBtn => _parallelConfig.Driver.FindByCssSelector(".btn.btn-default");

        public void EnterDetails(string name, string salary, string durationWorked, string grade, string email)
        {
            NameField.SendKeys(name);
            SalaryField.SendKeys(salary);
            DurationField.SendKeys(durationWorked);
            GradeField.SendKeys(grade);
            EmailField.SendKeys(email);
        }

        public EmployeeListPage ClickCreateButton()
        {
            CreateBtn.Click();
            return new EmployeeListPage(_parallelConfig);
        }

       
    }
}
