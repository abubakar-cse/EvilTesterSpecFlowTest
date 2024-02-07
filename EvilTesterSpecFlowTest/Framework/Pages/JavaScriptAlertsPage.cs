using Aquality.Selenium.Browsers;
using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace EvilTesterSpecFlowTest.Framework.Pages
{
    internal class JavaScriptAlertsPage : Form
    {
        private const string PageName = "Alerts In A New Window From JavaScript";
        //private static readonly By showPromptBox = By.Id("promptexample");
        //private static readonly By showPromptBox = By.XPath("//*[@id='promptexample']");
        //private static readonly By showPromptBox = By.XPath("//*[contains(@class,'styled-click-button')]");
        private IButton showPromptBox => ElementFactory.GetButton(By.XPath("//input[@onclick = 'show_prompt()']"), "Show PromptBox Button");
        //private ILabel showPromptBox = ElementFactory.GetLabel(By.XPath(string.Format(LocatorConstants.PreciseTextLocator, "Show prompt box")), "Show Prompt Box Label");
        //private ILabel showPromptBox = ElementFactory.GetLabel(By.XPath(string.Format(LocatorConstants.PartialTextLocator, "Show prompt box")), "Show Prompt Box Label");

        private ILabel WindowsLinksAndExample = ElementFactory.GetLabel(By.XPath(string.Format(LocatorConstants.PreciseTextLocator, "Windows Links and Examples")), "Page is Opened");
        public JavaScriptAlertsPage() : base(By.XPath(string.Format(LocatorConstants.PreciseTextLocator, PageName)), PageName)
        {
        }

        public void ClickOnShowPromptBox()
        {
            //AqualityServices.Browser.Driver.FindElement(showPromptBox).Click();
            showPromptBox.Click();
        }

        public bool IsWinPageAndExamplePageOpened()
        {
            return WindowsLinksAndExample.State.IsDisplayed;
        }
    }
}
