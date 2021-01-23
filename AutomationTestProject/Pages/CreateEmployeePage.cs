using System;
using System.Collections.Generic;
using System.Text;
using AutomationFramework.Base;
using OpenQA.Selenium;

namespace AutomationTestProject.Pages
{
    public class CreateEmployeePage : BasePage
    {
        public IWebElement NameField => Driver.FindElement(By.Id("Name"));
        public IWebElement SalaryField => Driver.FindElement(By.Id("Salary"));
        public IWebElement DurationField => Driver.FindElement(By.Id("DurationWorked"));
        public IWebElement GradeField => Driver.FindElement(By.Id("Grade"));
        public IWebElement EmailField => Driver.FindElement(By.Id("Email"));

        public IWebElement CreateBtn => Driver.FindElement(By.CssSelector(".btn.btn-default"));
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
            return GetInstance<EmployeeListPage>();
        }
    }
}
