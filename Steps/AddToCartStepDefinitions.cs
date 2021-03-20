using NUnit.Framework;
using OpenQA.Selenium;
using RozetkaSpecFlow.Pages;
using TechTalk.SpecFlow;

namespace RozetkaSpecFlow.Steps
{
    [Binding]
    public sealed class AddToCartStepDefinitions
    {

        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly IWebDriver driver;
        private HeaderPage headerPage;
        private ProductPage productPage;

        public AddToCartStepDefinitions(IWebDriver  driver)
        {
            this.driver = driver;
        }

        [Given(@"opened home page ""Rozetka"" site")]
        public void GivenOpenedHomePageSite()
        {
            driver.Navigate().GoToUrl("https://rozetka.com.ua/");
            driver.Manage().Window.Maximize();
            headerPage = new HeaderPage(driver);
        }

        [When(@"search for a product by product ID in the search field")]
        public void WhenSearchForAProductByProductIDInTheSearchField()
        {
            productPage = headerPage.FindProduct("191882153");
        }

        [When(@"add product to cart")]
        public void WhenAddProductToCart()
        {
            productPage.AddToCart();
        }

        [Then(@"check if the item has been added to the cart")]
        public void ThenCheckIfTheItemHasBeenAddedToTheCart()
        {
            Assert.AreEqual(productPage.GetProductTitle(), headerPage.OpenCart().GetProductTitle());
        }



    }
}
