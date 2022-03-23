using LinkGroup.DemoTests.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinkGroup.DemoTests.PageObjects
{
    class LinkGroupHomePage
    {
        public static IWebElement Button_AllowCookies_Homepage() => Driver.Instance.FindElement(By.CssSelector("a.cc-dismiss"));

        public static IWebElement Link_Contact_Homepage() => Driver.Instance.FindElement(By.XPath("//nav[@id='nav-main']//a[text()='Contact']"));

        public static IWebElement NavBurger_Homepage_MobileView() => Driver.Instance.FindElement(By.Id("nav-trigger"));

        public static IWebElement Link_Contact_Homepage_Mobile() => Driver.Instance.FindElement(By.XPath("//nav[@id='nav-mobile']//a[text()='Contact']"));

        public static IWebElement Header_Contact_ContactPage() => Driver.Instance.FindElement(By.CssSelector("h1"));

    }
}
