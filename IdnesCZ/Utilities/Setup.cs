using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdnesCZ.Setup
{  
    
    public class ElementsAndThreadSleep
    {
        IWebDriver webDriver = new Utilities.WebDriverSetup("Chrome").GetWebDriver();

        public void Login (string username, string password = "")
        {
            
            webDriver.FindElement(By.Name("")).SendKeys(username);
            webDriver.FindElement(By.Name("")).SendKeys(username);
            webDriver.FindElement(By.Id("portalogin-link"));
        }

        public void GoToWebSite (string suburl)
        {
            webDriver.Navigate().GoToUrl("https://idnes.cz" + suburl);
        }
        public void ClickOnCssSelectorElement (string selector)
        {
            webDriver.FindElement(By.CssSelector(selector)).Click();         
        }

        public void ClickOnXpathElement (string selector)
        {
            webDriver.FindElement(By.XPath(selector)).Click();
        }
        public void ClickOnIdElement(string selector)
        {
            webDriver.FindElement(By.Id(selector)).Click();
        }

        public void InputTextToCssSelectorElement (string selector, string value)
        {
            webDriver.FindElement(By.CssSelector(selector)).Click();
            webDriver.FindElement(By.CssSelector(selector)).SendKeys(value);
        }

        public void InputTextToIdElement(string selector, string value)
        {
            webDriver.FindElement(By.Id(selector)).Click();
            webDriver.FindElement(By.Id(selector)).SendKeys(value);
        }

        public void InputTextToNameElement(string selector, string value)
        {
            webDriver.FindElement(By.Id(selector)).Click();
            webDriver.FindElement(By.Id(selector)).SendKeys(value);
        }

    }
}
