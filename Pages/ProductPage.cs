using OpenQA.Selenium;
using RozetkaSpecFlow.ExtensionMethod;

namespace RozetkaSpecFlow.Pages
{
    public class ProductPage
    {
        private readonly IWebDriver driver;
        public ProductPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement txtProductTitle => driver.FindElement(By.ClassName("product__title"), 5);
        private IWebElement btnBuy => driver.FindElement(By.ClassName("button_size_large"), 5);

        public string GetProductTitle()
        {
            return txtProductTitle.Text;
        }

        public void AddToCart()
        {
            btnBuy.Click();
            driver.Navigate().Refresh();
        }
    }
}
