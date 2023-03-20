using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace GumtreeAdsBDD.Hooks
{
    [Binding]
    public class Hooks
    {
        private IWebDriver _driver;

        [BeforeScenario]
        public void BeforeScenario()
        {                                     
             _driver.Manage().Window.Maximize(); // Maximize the browser window
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _driver.Quit();
        }
    }
}
