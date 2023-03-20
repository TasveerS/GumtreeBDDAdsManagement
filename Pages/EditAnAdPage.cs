using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GumtreeAdsBDD.Pages
{
    public class EditAnAdPage
    {
        private readonly IWebDriver _driver;
   
        public EditAnAdPage(IWebDriver driver)
        {
            _driver = driver;
            Random random = new Random();
            int randomNumber = random.Next(1000, 9999);
            RandomNumber = randomNumber.ToString();
        }

        //WebElements
        public string RandomNumber { get; set; }
        protected internal IWebElement ListingTitleField => _driver.FindElement(By.ClassName("textarea"));
        protected internal IWebElement AdTitle => _driver.FindElement(By.XPath("//a[@class='title']"));
        protected internal IWebElement PostButton => _driver.FindElement(By.XPath("//span[.='Post']"));


        //Methods
        public string GetAdTitle()
        {
            return AdTitle.Text;
        }

        public void AppendAd()
        {
            Helper.Helper.ScrollToMiddle(); //Scrolls to middle of the screen where the title textbox is
            ListingTitleField.Click();
            ListingTitleField.SendKeys(RandomNumber);
        }

        public void PostAd()
        {
            Helper.Helper.ScrollToBottom(); // Scrolls to bottom of the screen where the post button is located
            PostButton.Click();
        }
    }
}
