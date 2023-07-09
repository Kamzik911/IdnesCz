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

        public void ClickOnCssSelector (string selector)
        {
            webDriver.FindElement(By.CssSelector(selector)).Click();         
        }  
        

        public void TextToCssSelector (string selector, string text)
        {
            webDriver.FindElement(By.CssSelector(selector)).Click();
            webDriver.FindElement(By.CssSelector(selector)).SendKeys(text);
        }

    }
}
