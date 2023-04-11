
namespace IdnesCZ
{
    public class Cookies
    {
        private IWebDriver driver = (new WebDriverSetup("Chrome").GetWebDriver());
        

        [SetUp]
        public void Setup()
        {
            driver.Manage().Window.Size.Width.Equals(1920);
            driver.Manage().Window.Size.Height.Equals(1080);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        public void Sleep()
        {

            Thread.Sleep(250);
        }

        [Test]
        public void DisagreeWebCookies()
        {
            driver.Navigate().GoToUrl("https://idnes.cz");

            //MoreInfoAboutCookies
            IWebElement MoreInfoAboutCookies = driver.FindElement(By.CssSelector("#didomi-notice-learn-more-button"));
            MoreInfoAboutCookies.Click();
            Sleep();
            Console.Write("MoreInfoAboutCookies Done");
            

            //DisAgreeDeviceInfo
            IWebElement DisAgreeDeviceInfo = driver.FindElement(By.CssSelector("#didomi-consent-popup > div > div > div > div > div.didomi-consent-popup-body.didomi-popup-body > div:nth-child(2) > div.didomi-consent-popup-categories.didomi-consent-popup-categories-nested > div:nth-child(1) > div > div.didomi-consent-popup-data-processing__buttons.didomi-consent-popup-data-processing__buttons_tcf_v2 > div > button:nth-child(1)"));
            DisAgreeDeviceInfo.Click();
            Sleep();

            //AgreeDeviceInfo
            driver.FindElement(By.CssSelector("#didomi-consent-popup > div > div > div > div > div.didomi-consent-popup-body.didomi-popup-body > div:nth-child(2) > div.didomi-consent-popup-categories.didomi-consent-popup-categories-nested > div:nth-child(1) > div > div.didomi-consent-popup-data-processing__buttons.didomi-consent-popup-data-processing__buttons_tcf_v2 > div > button:nth-child(2)")).Click();
            Sleep();

            //DisAgreePersonalisedAdvert
            driver.FindElement(By.CssSelector("#didomi-consent-popup > div > div > div > div > div.didomi-consent-popup-body.didomi-popup-body > div:nth-child(2) > div.didomi-consent-popup-categories.didomi-consent-popup-categories-nested > div:nth-child(2) > div > div.didomi-components-accordion-label-container > div.didomi-consent-popup-data-processing__buttons > div > button:nth-child(1)")).Click();
            Sleep();

            //AgreePersonalisedAdvert
            driver.FindElement(By.CssSelector("#didomi-consent-popup > div > div > div > div > div.didomi-consent-popup-body.didomi-popup-body > div:nth-child(2) > div.didomi-consent-popup-categories.didomi-consent-popup-categories-nested > div:nth-child(2) > div > div.didomi-components-accordion-label-container > div.didomi-consent-popup-data-processing__buttons > div > button:nth-child(2)")).Click();
            Sleep();

            //DisAgreePersonalData
            driver.FindElement(By.CssSelector("#didomi-consent-popup > div > div > div > div > div.didomi-consent-popup-body.didomi-popup-body > div:nth-child(2) > div.didomi-consent-popup-categories.didomi-consent-popup-categories-nested > div:nth-child(3) > div > div.didomi-components-accordion-label-container > div.didomi-consent-popup-data-processing__buttons > div > button:nth-child(1)")).Click();
            Sleep();

            //AgreePersonalData
            driver.FindElement(By.CssSelector("#didomi-consent-popup > div > div > div > div > div.didomi-consent-popup-body.didomi-popup-body > div:nth-child(2) > div.didomi-consent-popup-categories.didomi-consent-popup-categories-nested > div:nth-child(3) > div > div.didomi-components-accordion-label-container > div.didomi-consent-popup-data-processing__buttons > div > button:nth-child(2)")).Click();
            Sleep();

            //AgreeAll
            driver.FindElement(By.CssSelector("#didomi-radio-option-agree-to-all")).Click();
            Sleep();

            //DisAgreeAll
            driver.FindElement(By.CssSelector("#didomi-radio-option-disagree-to-all")).Click();
            Sleep();
        }

        [Test]
        public void ChooseAllPartners()
        {
            driver.FindElement(By.CssSelector("#didomi-consent-popup > div > div > div > div > div.didomi-consent-popup-body.didomi-popup-body > span > button")).Click();
            Sleep();

            //Disagreeallpartners            
            driver.FindElement(By.CssSelector("#didomi-consent-popup > div > div > div > div > div.didomi-consent-popup-body.didomi-popup-body > div.didomi-consent-popup-body__section > div.didomi-consent-popup-vendor.didomi-consent-popup-container-click-all > div.didomi-consent-popup-vendor__buttons > div > button.didomi-components-radio__option.didomi-components-radio__option--unselected")).Click();
            Sleep();

            //Agreeallpartners
            driver.FindElement(By.CssSelector("#didomi-consent-popup > div > div > div > div > div.didomi-consent-popup-body.didomi-popup-body > div.didomi-consent-popup-body__section > div.didomi-consent-popup-vendor.didomi-consent-popup-container-click-all > div.didomi-consent-popup-vendor__buttons > div > button.didomi-components-radio__option.didomi-components-radio__option--selected.didomi-components-radio__option--agree")).Click();
            Sleep();

            //Disagreeallpartners            
            driver.FindElement(By.CssSelector("#didomi-consent-popup > div > div > div > div > div.didomi-consent-popup-body.didomi-popup-body > div.didomi-consent-popup-body__section > div.didomi-consent-popup-vendor.didomi-consent-popup-container-click-all > div.didomi-consent-popup-vendor__buttons > div > button.didomi-components-radio__option.didomi-components-radio__option--unselected")).Click();
            Sleep();
        }

        [Test]
        public void PlusXAGIABTCF()
        {
            //Agree
            driver.FindElement(By.XPath("//*[@id=\"didomi-consent-popup\"]/div/div/div/div/div[3]/div[1]/div[2]/div/div[2]/div[2]/div/button[2]")).Click();
            Sleep();

            //DisAgree
            driver.FindElement(By.XPath("//*[@id=\"didomi-consent-popup\"]/div/div/div/div/div[3]/div[1]/div[2]/div/div[2]/div[2]/div/button[1]")).Click();
            Sleep();

            //ExpandPanel
            driver.FindElement(By.Id("didomi-vendor-92")).Click();
            Sleep();

            //CollapsePanel
            driver.FindElement(By.Id("didomi-vendor-92")).Click();
            Sleep();
        }

        [Test]
        public void TappxIABTCF()
        {
            //Agree
            driver.FindElement(By.XPath("//*[@id=\"didomi-consent-popup\"]/div/div/div/div/div[3]/div[1]/div[2]/div/div[4]/div[2]/div/button[2]")).Click();
            Sleep();

            //DisAgree
            driver.FindElement(By.XPath("//*[@id=\"didomi-consent-popup\"]/div/div/div/div/div[3]/div[1]/div[2]/div/div[4]/div[2]/div/button[1]")).Click();
            Sleep();

            //ExpandPanel
            driver.FindElement(By.Id("didomi-vendor-628")).Click();
            Sleep();

            //CollapsePanel
            driver.FindElement(By.Id("didomi-vendor-628")).Click();
            Sleep();
        }

        [Test]
        public void InfoAboutUser()
        {
            //ExpandInfoAboutUser
            IWebElement ExpandInfoAboutUser = driver.FindElement(By.XPath("//*[@id=\"didomi-consent-popup\"]/div/div/div/div/div[3]/div[2]/div/div[1]/div"));
            ExpandInfoAboutUser.Click();
            Sleep();

            //CollapseInfoAboutUser
            IWebElement CollapseInfoAboutUser = driver.FindElement(By.XPath("//*[@id=\"didomi-consent-popup\"]/div/div/div/div/div[3]/div[2]/div/div[1]/div"));
            CollapseInfoAboutUser.Click();
            Sleep();

            IWebElement AgreeMyChoices = driver.FindElement(By.XPath("//*[@id=\"didomi-consent-popup\"]/div/div/div/div/div[4]/div/button"));
            AgreeMyChoices.Click(); 
            Sleep();

            IWebElement AgreeMyChoicesCookies = driver.FindElement(By.XPath("//*[@id=\"didomi-consent-popup\"]/div/div/div/div/div[4]/div/button"));
            AgreeMyChoicesCookies.Click();
            Sleep();
            }




        //Can not click for now :-(
        /*[Test]
        public void ActiveAgentVirtualMindsGmbh()
        {
            //DisAgree
            driver.FindElement(By.ClassName("//*[@id=\"didomi-consent-popup\"]/div/div/div/div/div[3]/div[1]/div[2]/div/div[6]/div[2]/div/button[1]")).Click();

            //Agree
            IWebElement ActiveAgentdriverAgree = driver.FindElement(By.CssSelector("//*[@id=\"didomi-consent-popup\"]/div/div/div/div/div[3]/div[1]/div[2]/div/div[6]/div[2]/div/button[2]"));
            ActiveAgentdriverAgree.Click();
            Sleep();

            //ExpandPanel
            driver.FindElement(By.Id("didomi-vendor-40")).Click();
            Sleep();

            //CollapsePanel
            driver.FindElement(By.Id("didomi-vendor-40")).Click();
            Sleep();
        } 

        [Test]
        public void ActiveRadio()
        {
            //Agree
            driver.FindElement(By.XPath("//*[@id=\"didomi-consent-popup\"]/div/div/div/div/div[3]/div[1]/div[2]/div/div[7]/div[2]/div/button[2]")).Click();
            Sleep();

            //DisAgree
            driver.FindElement(By.XPath("//*[@id=\"didomi-consent-popup\"]/div/div/div/div/div[3]/div[1]/div[2]/div/div[7]/div[2]/div/button[1]")).Click();
            Sleep();

            //ExpandPanel
            driver.FindElement(By.Id("didomi-vendor-c:activerad-PLQjCHQ9")).Click();
            Sleep();

            //CollapsePanel
            driver.FindElement(By.Id("didomi-vendor-c:activerad-PLQjCHQ9")).Click();
            Sleep();
        }

        [Test]
        public void AdaraMediaUnlimited()
        {
            //Agree
            driver.FindElement(By.XPath("//*[@id=\"didomi-consent-popup\"]/div/div/div/div/div[3]/div[1]/div[2]/div/div[8]/div[2]/div/button[2]")).Click();
            Sleep();

            //DisAgree
            driver.FindElement(By.XPath("//*[@id=\"didomi-consent-popup\"]/div/div/div/div/div[3]/div[1]/div[2]/div/div[8]/div[2]/div/button[1]")).Click();
            Sleep();

            //ExpandPanel
            driver.FindElement(By.Id("didomi-vendor-57")).Click();
            Sleep();

            //CollapsePanel
            driver.FindElement(By.Id("didomi-vendor-57")).Click();
            Sleep();
        }

        [Test]
        public void AdformAS()
        {
            //Agree
            driver.FindElement(By.XPath("//*[@id=\"didomi-consent-popup\"]/div/div/div/div/div[3]/div[1]/div[2]/div/div[9]/div[2]/div/button[2]")).Click();
            Sleep();

            //DisAgree
            driver.FindElement(By.XPath("//*[@id=\"didomi-consent-popup\"]/div/div/div/div/div[3]/div[1]/div[2]/div/div[9]/div[2]/div/button[1]")).Click();
            Sleep();

            //ExpandPanel
            driver.FindElement(By.Id("didomi-vendor-50")).Click();
            Sleep();

            //CollapsePanel
            driver.FindElement(By.Id("didomi-vendor-50")).Click();
            Sleep();
        }

        [Test]
        public void AdobeAdvertisingCloud()
        {
            //Agree
            driver.FindElement(By.XPath("//*[@id=\"didomi-consent-popup\"]/div/div/div/div/div[3]/div[1]/div[2]/div/div[10]/div[2]/div/button[2]")).Click();
            Sleep();

            //DisAgree
            driver.FindElement(By.XPath("//*[@id=\"didomi-consent-popup\"]/div/div/div/div/div[3]/div[1]/div[2]/div/div[10]/div[2]/div/button[1]")).Click();
            Sleep();

            //ExpandPanel
            driver.FindElement(By.Id("didomi-vendor-264")).Click();
            Sleep();

            //CollapsePanel
            driver.FindElement(By.Id("didomi-vendor-264")).Click();
            Sleep();
            */
        /*    

        //ConfirmMyChoice
         driver.FindElement(By.CssSelector("#didomi-consent-popup > div > div > div > div > div.didomi-consent-popup-footer.didomi-popup-footer > div > button")).Click();
         Sleep();*/





    }
}
