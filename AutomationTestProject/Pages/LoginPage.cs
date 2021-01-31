using AutomationFramework.Base;
using AutomationFramework.Extensions;
using OpenQA.Selenium;

namespace AutomationTestProject.Pages
{
    public class LoginPage : BasePage
    {
        public LoginPage(ParallelConfig parallelConfig) : base(parallelConfig)
        {
        }

        public IWebElement txtUserName => _parallelConfig.Driver.FindById("UserName");
        public IWebElement txtPassword => _parallelConfig.Driver.FindById("Password");
        public IWebElement btnLogin => _parallelConfig.Driver.FindByCssSelector("input.btn");
        

        public void EnterLoginDetails(string username, string password)
        {
            txtUserName.SendKeys(username);
            txtPassword.SendKeys(password);
        }


        public HomePage ClickSubmitButton()
        {
            btnLogin.Submit();
            return new HomePage(_parallelConfig);
        }

        
    }
}
