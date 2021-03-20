using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace RozetkaSpecFlow.Pages.PagesComponents
{
    class CartComponent
    {
        private readonly IWebDriver driver;
        public CartComponent(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement ProductTitle => (new WebDriverWait(driver, TimeSpan.FromSeconds(10)))
        .Until(ExpectedConditions.ElementExists(By.ClassName("cart-product__title")));

        public String GetProductTitle()
        {
            return ProductTitle.Text;
        }
    }
}
