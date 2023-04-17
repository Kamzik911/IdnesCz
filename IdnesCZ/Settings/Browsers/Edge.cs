
namespace IdnesCZ.Settings.Browsers
{
    public class EdgeBrowser
    {
        private IWebDriver driver = new EdgeDriver();


        public IWebDriver GetEdgeBrowser()
        {
            return driver;
        }

    }
}
