using OpenQA.Selenium;
using System.Runtime.CompilerServices;

namespace Seznam.cz
{

    internal class WebDriverSetup
    {
        public IWebDriver driver;

        public WebDriverSetup(string ChooseDriver)
        {
            
            if (ChooseDriver == "Chrome")
            {
                this.driver = new ChromeDriver();
            }
            else if (ChooseDriver == "Edge")
            {
                this.driver = new EdgeDriver();
            }
            else if (ChooseDriver == "FireFox")
            {
                this.driver = new FirefoxDriver();
            }
            else
            {
                this.driver = new ChromeDriver();
            }
        }
        
        public IWebDriver GetWebDriver()
        {
            return this.driver;
        }
    }
}
