using Aquality.Selenium.Browsers;
using EvilTesterSpecFlowTest.Framework.Pages;
using TechTalk.SpecFlow;

namespace EvilTesterSpecFlowTest.StepDefinitions
{
    [Binding]
    internal class MainPageSteps
    {
        MainPage mainPage = new();
        private readonly Browser browser = AqualityServices.Browser;
        
        [Given(@"Navigate to the page")]
        public void GivenNavigateToThePage()
        {
            browser.GoTo("https://testpages.eviltester.com/styled/windows-test.html");
        }
    }
}
