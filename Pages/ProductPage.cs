using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace RozetkaSpecFlow.Pages
{
    class ProductPage
    {
        private readonly IWebDriver driver;
        public ProductPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement ProductTitle => (new WebDriverWait(driver, TimeSpan.FromSeconds(10)))
            .Until(ExpectedConditions.ElementExists(By.ClassName("product__title")));
        private IWebElement BuyButton => (new WebDriverWait(driver, TimeSpan.FromSeconds(10)))
            .Until(ExpectedConditions.ElementExists(By.ClassName("button_size_large")));

        public String GetProductTitle()
        {
            return ProductTitle.Text;
        }

        public void AddToCart()
        {
            BuyButton.Click();
            driver.Navigate().Refresh();
        }

    }
}
