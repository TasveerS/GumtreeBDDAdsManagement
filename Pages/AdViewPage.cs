using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GumtreeAdsBDD.Pages
{
    public class AdViewPage
    {
        private readonly IWebDriver _driver;
        public AdViewPage(IWebDriver driver)
        {
            _driver = driver;
        }

        //WebElements
        protected internal IWebElement PostedAdTitle => _driver.FindElement(By.TagName("h1"));

        //Methods
        public string NewPostedAdTitle()
        {
          try
            {
                return PostedAdTitle.Text;
            }
            catch (Exception E)
            {
                Console.WriteLine("Test Fail: unable get new ad's title  : {0}", E.Message);
                throw;
            }
        }
    }
}
