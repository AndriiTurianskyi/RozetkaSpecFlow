using OpenQA.Selenium;
using RozetkaSpecFlow.ExtensionMethod;

namespace RozetkaSpecFlow.Pages.PagesComponents
{
    public class CartComponent
    {
        private readonly IWebDriver driver;
        public CartComponent(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement txtProductTitle => driver.FindElement(By.ClassName("cart-product__title"), 5);

        public string GetProductTitle()
        {
            return txtProductTitle.Text;
        }
    }
}
