using System;
using TechTalk.SpecFlow;
using GumtreeAdsBDD.Constants;
using System.Configuration;
using OpenQA.Selenium;
using GumtreeAdsBDD.Pages;
using NUnit.Framework;

namespace GumtreeAdsBDD.StepDefinitions
{
    [Binding]
    public class AdManagementStepDefinitions
    {
        private IWebDriver _driver;

        private readonly AdViewPage _adViewPage;
        private readonly EditAnAdPage _editAnAdPage;
        private readonly MyAdsPage _myAdsPage;
        private readonly NavbarPage _navbarPage;
        private readonly LoginPage _loginPage;
        private readonly HomepagePage _homePage;
        public AdManagementStepDefinitions()
        {
            _adViewPage = new AdViewPage(_driver);
            _editAnAdPage = new EditAnAdPage(_driver);
            _myAdsPage = new MyAdsPage(_driver);
            _navbarPage = new NavbarPage(_driver);
            _loginPage = new LoginPage(_driver);
            _homePage = new HomepagePage(_driver);
        }

        [Given(@"I navigate to the Gumtree South Africa website")]
        public void GivenINavigateToTheGumtreeSouthAfricaWebsite()
        {
            _homePage.GoToGumtreeHomepage();
        }

        [When(@"I have entered (.*) and (.*) on the login page")]
        public void WhenIHaveEnteredUsernameAndPasswordOnTheLoginPage(string username, string password)
        {
            _navbarPage.ClickLoginButton();
            _loginPage.Login(username, password);
        }

        [Then(@"I navigate to ""([^""]*)""")]
        [When(@"I navigate to ""([^""]*)""")]
        public void WhenINavigateTo(string DropDownOption)
        {
            _navbarPage.SelectOptionFromDropdown(DropDownOption);
        }


        [Then(@"I should see an ad present")]
        public void ThenIShouldSeeAnAdPresent()
        {
            Assert.IsTrue(_myAdsPage.IsAdPresent(), "No Ads are present");
        }

        [When(@"I edit the ad")]
        public void WhenIEditTheAd()
        {
            var currentTitle = _myAdsPage.GetAdTitle();
            _myAdsPage.EditAd();
        }

        [When(@"I append a 4 digit random number to the title")]
        public void WhenIAppendAFourDigitRandomNumberToTheTitle()
        {
            _editAnAdPage.AppendAd();
        }


        [When(@"I post the ad")]
        public void WhenIPostTheAd()
        {
            _editAnAdPage.PostAd();
        }

        [Then(@"I should see the title with the updated random number")]
        public void ThenIShouldSeeTheTitleWithTheUpdatedRandomNumber()
        {
            string randomNumber = _editAnAdPage.RandomNumber;
            Assert.IsTrue(_adViewPage.NewPostedAdTitle().Contains(_editAnAdPage.RandomNumber), "Title not updated");
        }
    }
}
