using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GumtreeAdsBDD.Pages
{
    public class NavbarPage
    {
        private readonly IWebDriver _driver;
        public NavbarPage(IWebDriver driver)
        {
            _driver = driver;
        }

        //WebElements
        protected internal IWebElement LoginButton => _driver.FindElement(By.CssSelector(".sign-in"));
        protected internal IWebElement UserProfileDropdownButton => _driver.FindElement(By.CssSelector(".icon-chevron-down"));
        protected internal By UserProfileDropdownOption(string option) => By.XPath($"//a[.='{option}']");


        //Methods
        public void ClickLoginButton()
        {
            try
            {
                LoginButton.Click();
            }
            catch (Exception E)
            {
                Console.WriteLine("Test Fail: did not click SignIn button  : {0}", E.Message);
                throw;
            }
        }
        public void SelectOptionFromDropdown(string option)
        {
            try
            {
                UserProfileDropdownButton.Click();

                var userProfileDropdownOption = UserProfileDropdownOption(option);
                _driver.FindElement(userProfileDropdownOption).Click();
            }
            catch (Exception E)
            {
                Console.WriteLine("Test Fail: Unable to find dropdown option  : {0}", E.Message);
                throw;
            }
        }
    }
}
