using Applitools.Selenium;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ApplitoolsEye
{
    public class TestBase
    {
        public IWebDriver Driver { get; set; }
        public Eyes Eyes { get; set; }

        public const string AppName = "sample app 1";
        public const string TestName = "Test1";
        public Size Resolution720p => new Size(1280, 720);
        public Size Resolution1080p => new Size(1920, 1080);

        public void GoToPricingPage()
        {
            Driver.Navigate().GoToUrl("https://ultimateqa.com/automation/fake-pricing-page/#top");
        }

        [SetUp]
        public void SetupBeforeAnyTest()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            Eyes = new Eyes
            {
                ApiKey = Environment.GetEnvironmentVariable("APPLITOOL_API_KEY", EnvironmentVariableTarget.User)
            };
        }

        [TearDown]
        public void CleanupAfterEveryTest()
        {
            Driver.Close();
            Eyes.Close();
        }
    }
}
