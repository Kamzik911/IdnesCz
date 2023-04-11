
using System.Security.Cryptography.X509Certificates;

namespace IdnesCZ
{
    internal class LogInOutToAccount
    {
        private IWebDriver driver = (new WebDriverSetup("Chrome").GetWebDriver());

        [SetUp]
        public void Setup() 
        {
            driver.Manage().Window.Size.Width.Equals(1920);
            driver.Manage().Window.Size.Height.Equals(1080);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            
        }

        [SetUp]
        public void Sleep()
        {
            Thread.Sleep(250);
        }

        [Test]
        public void AvoidCookies()
        {
            driver.Navigate().GoToUrl("https://idnes.cz");

            driver.FindElement(By.CssSelector("#didomi-notice-learn-more-button")).Click();
            driver.FindElement(By.CssSelector("#didomi-radio-option-disagree-to-all")).Click();
            driver.FindElement(By.XPath("//*[@id=\"didomi-consent-popup\"]/div/div/div/div/div[4]/div/button")).Click();

        }
        [Test]
        public void LoginUser()
        {
            //LoginPage
            driver.FindElement(By.CssSelector("#portalogin-link")).Click();

            //SetEmail
            driver.FindElement(By.CssSelector("#prem_login > div > div:nth-child(3) > input[type=text]")).SendKeys("swtester911@gmail.com");

            //SetPassword
            driver.FindElement(By.CssSelector("#prem_login > div > div:nth-child(4) > input[type=password]")).SendKeys("asdf56sadf76");

            //ClickToLogin
            driver.FindElement(By.CssSelector("#prem_login > div > div.premup-btn > button")).Click();

        }
        [Test]
        public void LogoutUser()
        {
            //AccountPage
            driver.FindElement(By.XPath("//*[@id=\"portal-g0\"]/ul/li[3]/a[2]")).Click();

            //LogOutUser
            driver.FindElement(By.XPath("//*[@id=\"content\"]/div[2]/div[1]/div[2]/ul[2]/li[2]/a")).Click();
        
            driver.Quit();
        }


    }

}
