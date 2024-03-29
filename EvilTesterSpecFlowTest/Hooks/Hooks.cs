﻿using Aquality.Selenium.Browsers;
using Aquality.Selenium.Core.Utilities;
using TechTalk.SpecFlow;

namespace EvilTesterSpecFlowTest.Framework.Hooks
{
    [Binding]
    internal class Hooks
    {
        private readonly Browser browser = AqualityServices.Browser;
        private static readonly JsonSettingsFile config = new("config.json");

        [BeforeScenario]
        public void Setup()
        {
            browser.Maximize();
            browser.GoTo(config.GetValue<string>("url"));
        }

        [AfterScenario]
        public void TearDown()
        {
            browser.Quit();
        }
    }
}
