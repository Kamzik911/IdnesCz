namespace IdnesCZ.Utilities
{
    internal class WebDriverSetup
    {
        public IWebDriver webDriver;

        public WebDriverSetup(string ChooseDriver)
        {
            if (ChooseDriver == "Chrome")
            {
                webDriver = new ChromeDriver();
            }
            else if (ChooseDriver == "Firefox")
            {
                webDriver = new FirefoxDriver();
            }
            else if (ChooseDriver == "Edge")
            {
                webDriver = new EdgeDriver();
            }
            else
            {
                webDriver = new ChromeDriver();
            }
        }
        public IWebDriver GetWebDriver()
        {
            return webDriver;
        }
    }
}
