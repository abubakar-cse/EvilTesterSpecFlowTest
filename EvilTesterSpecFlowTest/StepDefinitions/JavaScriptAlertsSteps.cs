using Aquality.Selenium.Browsers;
using EvilTesterSpecFlowTest.Framework.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace EvilTesterSpecFlowTest.StepDefinitions
{
    [Binding]
    internal class JavaScriptAlertsSteps
    {
        private MainPage mainPage = new();
        private JavaScriptAlertsPage javaScriptAlertsPage = new();
        


        [When(@"Windows Links and Examples page is opened")]
        public void WhenWindowsLinksAndExamplesPageIsOpened()
        {
            Assert.IsTrue(javaScriptAlertsPage.IsWinPageAndExamplePageOpened(), "Page is not Opened");
        }

        [When(@"I Click '([^']*)' link")]
        public void WhenIClickLink(string link)
        {
            mainPage.ClickNavigationLink("Alerts In A New Window From JavaScript");
        }

        [When(@"Click Show prompt box")]
        public void WhenClickShowPromptBox()
        {
            var windowHandles = AqualityServices.Browser.Driver.WindowHandles;
            AqualityServices.Browser.Driver.SwitchTo().Window(windowHandles[1]);
            javaScriptAlertsPage.ClickOnShowPromptBox();
        }

        [Then(@"Change the prompt and accept the alert")]
        public void ThenChangeThePromptAndAcceptTheAlert()
        {
            AqualityServices.Browser.HandleAlert(AlertAction.Accept, "Change Text");
        }
    }
}
