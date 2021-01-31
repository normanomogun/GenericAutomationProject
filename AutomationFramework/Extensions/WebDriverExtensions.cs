using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace AutomationFramework.Extensions
{
    public static class WebDriverExtensions
    {
        public static IWebElement FindById(this RemoteWebDriver driver, string locator)
        {
            try
            {
                if (driver.FindElement(By.Id(locator)).Displayed)
                {
                    return driver.FindElement(By.Id(locator));
                }
                
            }
            catch (Exception e)
            {
                throw new Exception($"Could not find element with ID locator '{locator}'");
            }

            return null;
        }

        public static IWebElement FindByCssSelector(this RemoteWebDriver driver, string locator)
        {
            try
            {
                if (driver.FindElement(By.CssSelector(locator)).Displayed)
                {
                    return driver.FindElement(By.CssSelector(locator));
                }

            }
            catch (Exception e)
            {
                throw new Exception($"Could not find element with CssSelector locator '{locator}'");
            }

            return null;
        }

        public static IWebElement FindByXPath(this RemoteWebDriver driver, string locator)
        {
            try
            {
                if (driver.FindElement(By.XPath(locator)).Displayed)
                {
                    return driver.FindElement(By.XPath(locator));
                }

            }
            catch (Exception e)
            {
                throw new Exception($"Could not find element with XPath locator '{locator}'");
            }

            return null;
        }



    }
}
