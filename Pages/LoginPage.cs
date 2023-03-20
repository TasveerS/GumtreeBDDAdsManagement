using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GumtreeAdsBDD.Pages
{
    public class LoginPage
    {
        private readonly IWebDriver _driver;

        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }

        //WebElements
        protected internal IWebElement InputUsername => _driver.FindElement(By.XPath("//div[contains(@class,'login-email-field')]//input[contains(@class,'input-main')]"));
        protected internal IWebElement InputPassword => _driver.FindElement(By.XPath("//div[contains(@class,'login-pwd-field')]//input[contains(@class,'input-main')]"));
        protected internal IWebElement SignInButton => _driver.FindElement(By.CssSelector(".login-submit"));

        //Methods
        public void Login(string username, string password)
        {
            try
            {
                InputUsername.Clear();
                InputUsername.SendKeys(username);
                InputPassword.Clear();
                InputPassword.SendKeys(password);
                SignInButton.Click();
            }
            catch (Exception E)
            {
                Console.WriteLine("Test Fail: Username and Password entry failed  : {0}", E.Message);
                throw;
            }
        }
    }
}
