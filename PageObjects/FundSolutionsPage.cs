using LinkGroup.DemoTests.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinkGroup.DemoTests.PageObjects
{
    class FundSolutionsPage
    {
        public static IWebElement Link_Funds_FundSolutionsPage() => Driver.Instance.FindElement(By.CssSelector("#navItem-funds a.nav-link.dropdown-toggle"));

        public static IWebElement Link_UKInvestors_FundSolutionsPage() => Driver.Instance.FindElement(By.XPath("//div[contains(@class,'dropdown-menu')]//a[contains(text(),'UK')]"));

        public static IWebElement Link_IrishInvestors_FundSolutionsPage() => Driver.Instance.FindElement(By.XPath("//div[contains(@class,'dropdown-menu')]//a[contains(text(),'Irish')]"));

        public static IWebElement Link_SwissInvestors_FundSolutionsPage() => Driver.Instance.FindElement(By.XPath("//div[contains(@class,'dropdown-menu')]//a[contains(text(),'Swiss')]"));

    }
}
