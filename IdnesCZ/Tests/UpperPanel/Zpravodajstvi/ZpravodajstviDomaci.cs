using IdnesCZ.Settings.Browsers;
using OpenQA.Selenium.Interactions;

namespace IdnesCZ.Tests.UpperPanel.Zpravodajstvi
{
    internal class ZpravodajstviDomaci
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
        public void ClickOnZpravodajstviDomaci()
        {            
            //Go to URL
            driver.Navigate().GoToUrl("https://idnes.cz");
            IWebElement ClickToIdnes = driver.FindElement(By.CssSelector("#p-sph > a"));
            ClickToIdnes.Click();
            Sleep();
            Console.WriteLine("Click to \"Idnes\" element (main site) done");

            //Cookies Settings
            IWebElement CookiesSettings = driver.FindElement(By.CssSelector("#didomi-notice-learn-more-button"));
            CookiesSettings.Click();
            Sleep();
            Console.WriteLine("Click on cookies settings done");

            IWebElement DenyAllCookies = driver.FindElement(By.CssSelector("#didomi-consent-popup > div > div > div > div > div.didomi-consent-popup-footer.didomi-popup-footer > div > button.didomi-components-button.didomi-button.didomi-button-standard.standard-button"));
            DenyAllCookies.Click();
            Sleep();
            Console.WriteLine("Deny all cookies done");

            IWebElement Zpravodajstvi = driver.FindElement(By.CssSelector("#p-menu-1 > li:nth-child(2) > a"));
            Zpravodajstvi.Click();
            Sleep();
            Console.WriteLine("Click on \"zpravodajstvi\" done");

            IWebElement ZpravodajstviDomaci = driver.FindElement(By.CssSelector("#domaci > a"));
            Zpravodajstvi.Click();
            Sleep();
        }

        [Test]
        public void QuitWebDriver()
        {
            driver.Quit();
        }

    }
}
