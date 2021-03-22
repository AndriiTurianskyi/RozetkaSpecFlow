using OpenQA.Selenium;
using RozetkaSpecFlow.ExtensionMethod;
using RozetkaSpecFlow.Pages.PagesComponents;

namespace RozetkaSpecFlow.Pages
{
    public class HeaderPage
    {
        private readonly IWebDriver driver;
        public HeaderPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement searchField => driver.FindElement(By.Name("search"), 5);
        private IWebElement btnSearch => driver.FindElement(By.CssSelector("form > button"), 5);
        private IWebElement btnCart => driver.FindElement(By.ClassName("header__button--active"), 5);

        public ProductPage FindProduct(int productId)
        {
            searchField.SendKeys(productId.ToString());
            btnSearch.Click();
            return new ProductPage(driver);
        }

        public CartComponent OpenCart()
        {
            btnCart.Click();
            return new CartComponent(driver);
        }
    }
}
