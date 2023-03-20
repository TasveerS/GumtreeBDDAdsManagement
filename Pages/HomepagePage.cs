using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GumtreeAdsBDD.Pages
{
    public class HomepagePage
    {
        private readonly IWebDriver _driver;
        public HomepagePage(IWebDriver driver)
        {
            _driver = driver;
        }


        //Methods
        public void GoToGumtreeHomepage()
        {
            try
            {
                _driver.Navigate().GoToUrl(Constants.Constants.GumtreeUrl);
            }
            catch (Exception E)
            {
                Console.WriteLine("Test Fail: website URL unavailable  : {0}", E.Message);
                throw;
            }
        }
    }
}
