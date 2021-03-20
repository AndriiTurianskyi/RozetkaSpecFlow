using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using RozetkaSpecFlow.Pages.PagesComponents;
using SeleniumExtras.WaitHelpers;
using System;

namespace RozetkaSpecFlow.Pages
{
    class HeaderPage
    {
        private readonly IWebDriver driver;
        public HeaderPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement SearchField => (new WebDriverWait(driver, TimeSpan.FromSeconds(10)))
            .Until(ExpectedConditions.ElementExists(By.Name("search")));
        private IWebElement SearchButton => (new WebDriverWait(driver, TimeSpan.FromSeconds(10)))
            .Until(ExpectedConditions.ElementExists(By.CssSelector("form > button")));
        private IWebElement CartButton => (new WebDriverWait(driver, TimeSpan.FromSeconds(10)))
            .Until(ExpectedConditions.ElementExists(By.ClassName("header__button--active")));

        public ProductPage FindProduct(String productId)
        {
            SearchField.SendKeys(productId);
            SearchButton.Click();
            return new ProductPage(driver);
        }

        public CartComponent OpenCart()
        {
            CartButton.Click();
            return new CartComponent(driver);
        }
    }
}
