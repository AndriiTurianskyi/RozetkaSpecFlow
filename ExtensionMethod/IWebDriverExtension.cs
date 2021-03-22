using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace RozetkaSpecFlow.ExtensionMethod
{
    public static class IWebDriverExtension
    {
        public static IWebElement FindElement(this IWebDriver driver, By by, int timeoutInSec)
        {
            return new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSec)).Until(ExpectedConditions.ElementIsVisible(by));
        }
    }
}
