using AutomationFramework.Base;
using AutomationTestProject.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace AutomationTestProject.Steps
{
    [Binding]
    public class LoginSteps :BaseClass
    {
        private ParallelConfig _parallelConfig;

        public LoginSteps(ParallelConfig parallelConfig) : base(parallelConfig)
        {
            _parallelConfig = parallelConfig;
        }
      
        //public IWebDriver Driver { get; set; }
        [Given(@"I am on the EA website")]
        public void GivenIAmOnTheEAWebsite()
        {
            _parallelConfig.CurrentPage = new HomePage(_parallelConfig);
           var isBrowserOnHomePage =  _parallelConfig.CurrentPage.As<HomePage>().IsBrowserOnHomePage();
           Assert.IsTrue(isBrowserOnHomePage, "Something might be broken the browser is not on home page");
        }

        [When(@"I click login link")]
        public void WhenIClickLoginLink()
        {
            _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<HomePage>().ClickLoginLink();
        }


        [When(@"I enter login details")]
        public void WhenIEnterLoginDetails(Table table)
        {
            dynamic cred = table.CreateDynamicInstance();
            //CurrentPage = GetInstance<LoginPage>();
            //CurrentPage = CurrentPage.As<HomePage>().ClickLoginLink();
            _parallelConfig.CurrentPage.As<LoginPage>().EnterLoginDetails(cred.UserName, cred.Password);
        }


        [When(@"I click submit button")]
        public void WhenIClickSubmitButton()
        {
            _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<LoginPage>().ClickSubmitButton();
        }


        [When(@"I click employeelist")]
        public void WhenIClickEmployeelist()
        {
            _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<HomePage>().ClickEmployeeListLink();

        }

       

        [Then(@"I am logged in successfully")]
        public void ThenIAmLoggedInSuccessfully()
        {
           var isLoggedIn = _parallelConfig.CurrentPage.As<HomePage>().IsSuccessFullyLoggedIn();
           Assert.IsTrue(isLoggedIn, "User is not logged in");
        }


        
    }
}
