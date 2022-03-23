using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace LinkGroup.DemoTests.Hooks
{
    [Binding]
    public sealed class TestHooks
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeFeature("desktop")]
        public static void Setup()
        {
            var options = new ChromeOptions();
            options.AddArguments("--disable-plugins", "start-maximized");
            Driver.Instance = new ChromeDriver(options);

        }
        [BeforeFeature("mobile")]
        public static void MobileSetup()
        {
            var options = new ChromeOptions();
            options.EnableMobileEmulation("iPhone SE");
            Driver.Instance = new ChromeDriver(options);
        }
          
        [AfterFeature]
        public static void TearDown()
        {
            Driver.Instance.Close();
            Driver.Instance.Quit();
            Driver.KillChromeDriverProcess();
        }
        [AfterScenario]
        public static void ClearCookies()
        {
            Driver.Instance.Manage().Cookies.DeleteAllCookies();
        }
    }
}
