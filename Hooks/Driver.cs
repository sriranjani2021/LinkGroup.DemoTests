using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace LinkGroup.DemoTests.Hooks
{
    class Driver
    {
        public static IWebDriver Instance { get; set; }

        public static void WaitForPageToLoad()
        {
            TimeSpan ts = TimeSpan.FromSeconds(40);
            WebDriverWait wait = new WebDriverWait(Instance, ts);
            Instance.Manage().Timeouts().PageLoad = ts;
        }

        public static void KillChromeDriverProcess()
        {
            Process[] chromeDriverProcesses = Process.GetProcessesByName("chromedriver");

            foreach (var chromeDriverProcess in chromeDriverProcesses)
            {
                chromeDriverProcess.Kill();
            }
        }
        public static void HoverAnElement(IWebElement element)
        {
            Actions actions = new Actions(Instance);
            actions.MoveToElement(element).Perform();
        }
        public static void Wait(int waitTime)
        {
            Thread.Sleep(waitTime);
        }
    }
}
