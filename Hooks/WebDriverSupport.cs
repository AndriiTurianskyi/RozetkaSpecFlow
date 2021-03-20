using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace RozetkaSpecFlow.Hooks
{
    [Binding]
    public class WebDriverSupport
    {
        private readonly IObjectContainer container;
        private ChromeDriver webdriver;

        public WebDriverSupport(IObjectContainer container)
        {
            this.container = container;
        }

        [BeforeScenario]
        public void InitializeWebDriver()
        {
            this.webdriver = new ChromeDriver();
            container.RegisterInstanceAs<IWebDriver>(webdriver);
        }

        [AfterStep]
        public void DestroyWebDriver()
        {
            IWebDriver driver = container.Resolve<IWebDriver>();
            driver.Close();
            driver.Dispose();
        }
    }
}

