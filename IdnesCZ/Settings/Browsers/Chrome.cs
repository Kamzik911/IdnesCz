
namespace IdnesCZ.Settings.Browsers
{
    public class ChromeBrowser
    {
        private IWebDriver driver = new ChromeDriver();

        
        public IWebDriver GetChromeBrowser()
        {
            return driver;          
        }
        
    }   
}
