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
    public sealed class FundSolutionsSteps
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        public FundSolutionsSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [When(@"I view Funds")]
        public void WhenIViewFunds()
        {
            var FundsLink = FundSolutionsPage.Link_Funds_FundSolutionsPage();
            Assert.IsTrue(FundsLink.Displayed);
            Driver.HoverAnElement(FundsLink);
        }

        [Then(@"I can select the investment managers for '(.*)' investors")]
        public void ThenICanSelectTheInvestmentManagersForInvestors(string jurisdiction)
        {
            switch(jurisdiction)
            {
                case "UK":
                    var UKLink = FundSolutionsPage.Link_UKInvestors_FundSolutionsPage();
                    Assert.IsTrue(UKLink.Displayed);
                    Assert.AreEqual( Utilities.UKInvestorLinkText, UKLink.Text);
                    break;
                case "Irish":
                    var IrishLink = FundSolutionsPage.Link_IrishInvestors_FundSolutionsPage();
                    Assert.IsTrue(IrishLink.Displayed);
                    Assert.AreEqual(Utilities.IrishInvestorLinkText, IrishLink.Text);
                    break;
                case "Swiss":
                    var SwissLink = FundSolutionsPage.Link_SwissInvestors_FundSolutionsPage();
                    Assert.IsTrue(SwissLink.Displayed);
                    Assert.AreEqual(Utilities.SwissInvestorLinkText, SwissLink.Text);
                    break;
            }
        }

    }
}
