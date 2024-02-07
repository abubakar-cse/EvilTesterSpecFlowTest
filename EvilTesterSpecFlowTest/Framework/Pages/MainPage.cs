using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace EvilTesterSpecFlowTest.Framework.Pages
{
    internal class MainPage : Form
    {
        private ILink navigationLink(string navigation) => ElementFactory.GetLink(By.XPath(string.Format(LocatorConstants.PreciseTextLocator, navigation)), "Navigation Link");

        public MainPage() : base(By.XPath(string.Format(LocatorConstants.PreciseTextLocator, "Windows Links and Examples")), "Main page")
        {
        }
        public void ClickNavigationLink(string navigationName)
        {
            navigationLink(navigationName).Click();
        }
    }
}
