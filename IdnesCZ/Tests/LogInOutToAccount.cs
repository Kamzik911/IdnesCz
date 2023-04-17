﻿using IdnesCZ.Users;
using IdnesCZ.Settings.Browsers;

namespace IdnesCZ.Tests
{
    internal class LogInOutToAccount
    {
        private IWebDriver driver = new ChromeBrowser().GetChromeBrowser();
        

        [SetUp]
        public void Setup()
        {
            driver.Manage().Window.Size.Width.Equals(1920);
            driver.Manage().Window.Size.Height.Equals(1080);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            Thread.Sleep(250);

            /*var i = 1;
            Console.WriteLine(nameof(i));*/
        }               

        [Test]
        public void UserLoginLogout()
        {
            driver.Navigate().GoToUrl("https://idnes.cz");
            Console.WriteLine("URL open");

            driver.FindElement(By.CssSelector("#didomi-notice-learn-more-button")).Click();
            driver.FindElement(By.CssSelector("#didomi-radio-option-disagree-to-all")).Click();
            driver.FindElement(By.XPath("//*[@id=\"didomi-consent-popup\"]/div/div/div/div/div[4]/div/button")).Click();
                    
            //LoginPage
            driver.FindElement(By.CssSelector("#portalogin-link")).Click();

            //SetEmail
            IWebElement setEmail = driver.FindElement(By.CssSelector("#prem_login > div > div:nth-child(3) > input[type=text]"));
            setEmail.SendKeys(User1.Email);

            //SetPassword
            driver.FindElement(By.CssSelector("#prem_login > div > div:nth-child(4) > input[type=password]")).SendKeys(User1.Password);

            //ClickToLogin
            driver.FindElement(By.CssSelector("#prem_login > div > div.premup-btn > button")).Click();

            //AccountPage
            driver.FindElement(By.XPath("//*[@id=\"portal-g0\"]/ul/li[3]/a[2]")).Click();

            //LogOutUser
            driver.FindElement(By.XPath("//*[@id=\"content\"]/div[2]/div[1]/div[2]/ul[2]/li[2]/a")).Click();

            driver.Quit();
        }


    }

}