using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using AutomationFramework.Base;
using AutomationTestProject.Pages;
using Microsoft.Extensions.FileSystemGlobbing.Internal.PathSegments;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace AutomationTestProject.Steps
{
    [Binding]
    public class EmployeeSteps : BaseClass
    {
        [When(@"I click createnew button")]
        public void WhenIClickCreatenewButton()
        {
            CurrentPage = CurrentPage.As<EmployeeListPage>().ClickCreateNewButton();
        }

        [When(@"I enter employee details")]
        public void WhenIEnterEmployeeDetails(Table table)
        {
             dynamic empDetails = table.CreateDynamicInstance();
            // var name = empDetails.Name;
            // var salary = empDetails.Salary;
            // var dur = empDetails.DurationWorked;
            // var grad = empDetails.Grade;
            // var email = empDetails.Email;
            CurrentPage.As<CreateEmployeePage>().EnterDetails(empDetails.Name, empDetails.Salary.ToString(),
                empDetails.DurationWorked.ToString(), empDetails.Grade.ToString(), empDetails.Email);
        }

        [When(@"I click create button")]
        public void WhenIClickCreateButton()
        {
            CurrentPage = CurrentPage.As<CreateEmployeePage>().ClickCreateButton();
        }

    }
}
