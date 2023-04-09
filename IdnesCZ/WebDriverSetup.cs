
namespace IdnesCZ
{
    internal class WebDriverSetup
    {
        private IWebDriver driver;

        
        public WebDriverSetup(string ChooseDriver)
        {
            if (ChooseDriver == "Chrome")
            {
                this.driver = new ChromeDriver();
            }
            else if (ChooseDriver == "Firefox")
            {
                this.driver = new FirefoxDriver();
            }
            else if (ChooseDriver == "Edge")
            {
                this.driver = new EdgeDriver();
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
