
namespace IdnesCZ.Settings.Browsers
{
    public class FirefoxBrowser
    {
        private IWebDriver driver = new FirefoxDriver();


        public IWebDriver GetFirefoxBrowser()
        {
            return driver;
        }

    }
}
