

using OpenQA.Selenium.Internal;
using OpenQA.Selenium.Support.Events;

namespace Seznam.cz
{
    public class MainLogin
    {
       
    [Test]
        public void Login()
        {

        IWebDriver driver = (new WebDriverSetup("Chrome")).GetWebDriver();

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            driver.Navigate().GoToUrl("https://idnes.cz");
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector("#didomi-notice-agree-button")).Click();
            driver.FindElement(By.CssSelector("#p-sph > a")).Click();
            driver.FindElement(By.CssSelector("#p-menu-1 > li:nth-child(2) > a"));

            //driver.Quit();

            ;
        }
        
    }
}