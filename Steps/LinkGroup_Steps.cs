using LinkGroup.DemoTests.Hooks;
using LinkGroup.DemoTests.PageObjects;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace LinkGroup.DemoTests.Steps
{
    [Binding]
    public sealed class LinkGroup_Steps
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly FeatureContext _featureContext;

        public LinkGroup_Steps(FeatureContext featureContext)
        {
            _featureContext = featureContext;
        }

        [Given(@"I have opened the '(.*)' page")]
        public void GivenIHaveOpenedThePage(string page)
        {
            switch(page)
            {
                case "Home":
                    Driver.Instance.Navigate().GoToUrl(Utilities.LinkGroupUrl);
                    break;

                case "Fund Solutions":
                    Driver.Instance.Navigate().GoToUrl(Utilities.FundSolutionsUrl);
                    break;
            }
        }


        [Then(@"the page is displayed")]
        public void ThenThePageIsDisplayed()
        {
            Assert.AreEqual( Utilities.LinkGroupWebsiteTitle, Driver.Instance.Title , "Expected Title is not displayed");
        }
        [Given(@"I have agreed to the cookie policy")]
        public void GivenIHaveAgreedToTheCookiePolicy()
        {
            try
            {
                var AllowCookiesButton = LinkGroupHomePage.Button_AllowCookies_Homepage();
                Assert.IsTrue(AllowCookiesButton.Displayed);
                AllowCookiesButton.Click();
                Driver.Wait(100);
            }
            catch(Exception)
            { throw; }
        }
        [When(@"I select Contact")]
        public void WhenISelectContact()
        {
            if (_featureContext.FeatureInfo.Title == "LinkGroup_Desktop")
            {
                var ContactLink = LinkGroupHomePage.Link_Contact_Homepage();
                Assert.IsTrue(ContactLink.Displayed, "Contact Link is not displayed on the page");
                ContactLink.Click();
            }
            else
            {
                var NavBurger = LinkGroupHomePage.NavBurger_Homepage_MobileView();
                Assert.IsTrue(NavBurger.Displayed);
                NavBurger.Click();
                Driver.Wait(200);
                var MobileViewContactLink = LinkGroupHomePage.Link_Contact_Homepage_Mobile();
                Assert.IsTrue(MobileViewContactLink.Displayed, "Contact Link is not displayed on the page");
                MobileViewContactLink.Click();
            }
        }
        [Then(@"the Contact page is displayed")]
        public void ThenTheContactPageIsDisplayed()
        {
            Driver.WaitForPageToLoad();
            var HeaderContactPage = LinkGroupHomePage.Header_Contact_ContactPage();
            Assert.IsTrue(HeaderContactPage.Displayed, "Header is not displayed in Contact page");
            Assert.AreEqual( Utilities.ContactPageHeader, HeaderContactPage.Text , "Header is displayed on the page but the wording is wrong");
            Assert.IsTrue(LinkGroupHomePage.Link_Contact_Homepage().GetAttribute("class").Contains("active"), "The contact page is displayed correctly but the navigation link is not active");
        }
    }
}
