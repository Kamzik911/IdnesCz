using IdnesCZ.Settings.Browsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdnesCZ.Tests.UpperPanel.Zpravodajstvi
{
    internal class MainSiteUkrajina
    {

        private IWebDriver driver = new ChromeBrowser().GetChromeBrowser();

        [SetUp]
        public void Setup()
        {
            driver.Manage().Window.Size.Width.Equals(1920);
            driver.Manage().Window.Size.Height.Equals(1080);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            Thread.Sleep(250);
        }

        private void Sleep()
        {
            Thread.Sleep(250);
        }

        [Test]
        public void ZpravodajstviUkrajina()
        {
            driver.Navigate().GoToUrl("https://idnes.cz");
            IWebElement IdnesCookies = driver.FindElement(By.CssSelector("#didomi-notice-learn-more-button"));
            IdnesCookies.Click();
            IWebElement DisAgreeCookies = driver.FindElement(By.CssSelector("#didomi-consent-popup > div > div > div > div > div.didomi-consent-popup-footer.didomi-popup-footer > div > button.didomi-components-button.didomi-button.didomi-button-standard.standard-button"));
            DisAgreeCookies.Click();
            Sleep();
            IWebElement ZpravodajstviUkrajina = driver.FindElement(By.CssSelector("#p-menu-1 > li:nth-child(3) > a"));
            ZpravodajstviUkrajina.Click();
            Sleep();
            driver.Quit();
        }

    }
}
