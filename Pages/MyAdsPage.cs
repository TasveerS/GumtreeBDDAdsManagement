using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GumtreeAdsBDD.Pages
{
    public class MyAdsPage
    {

        private readonly IWebDriver _driver;
        public MyAdsPage(IWebDriver driver)
        {
            _driver = driver;
        }

        //WebElements
        protected internal IWebElement EditAdButton => _driver.FindElement(By.ClassName("icon-edit-my-ad"));
        protected internal IWebElement AdTitle => _driver.FindElement(By.XPath("//a[@class='title']"));
        protected internal IList<IWebElement> MyAdsList => (IList<IWebElement>)_driver.FindElement(By.XPath("my-ads-list"));

        //Methods
        public void EditAd()
        {
            try
            {
                EditAdButton.Click();
            }
            catch (Exception E)
            {
                Console.WriteLine("Test Fail: Attempting to click Edit has failed  : {0}", E.Message);
                throw;
            }
        }

        public string GetAdTitle()
        {
            try
            {
                return AdTitle.Text;
            }
            catch (Exception E)
            {
                Console.WriteLine("Test Fail: Unable to get Ad Title successfully  : {0}", E.Message);
                throw;
            }
        }

        public bool IsAdPresent()
        {
            try
            {
                if (MyAdsList.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception E)
            {
                Console.WriteLine("Test Fail: Unable to verify Ads for user  : {0}", E.Message);
                throw;
            }
        }

    }
}
