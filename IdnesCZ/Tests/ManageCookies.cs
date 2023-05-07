using IdnesCZ.Settings.Browsers;
using NUnit.Framework.Internal;
using System.Security.Cryptography.X509Certificates;

namespace IdnesCZ.Tests
{
    public class ManageCookies
    {
        private IWebDriver driver = new ChromeBrowser().GetChromeBrowser();


        [SetUp]
        public void Setup()
        {
            driver.Manage().Window.Size.Width.Equals(1920);
            driver.Manage().Window.Size.Height.Equals(1080);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
        }
        private void Sleep()
        {
            Thread.Sleep(250);
        }

        [Test]
        public void AllowDanyWebCookies()
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
            IWebElement AgreeDeviceInfo = driver.FindElement(By.CssSelector("#didomi-consent-popup > div > div > div > div > div.didomi-consent-popup-body.didomi-popup-body > div:nth-child(2) > div.didomi-consent-popup-categories.didomi-consent-popup-categories-nested > div:nth-child(1) > div > div.didomi-consent-popup-data-processing__buttons.didomi-consent-popup-data-processing__buttons_tcf_v2 > div > button:nth-child(2)"));
            AgreeDeviceInfo.Click();
            Sleep();

            //DisAgreePersonalisedAdvert
            IWebElement DisAgreePersonalisedAdvert = driver.FindElement(By.CssSelector("#didomi-consent-popup > div > div > div > div > div.didomi-consent-popup-body.didomi-popup-body > div:nth-child(2) > div.didomi-consent-popup-categories.didomi-consent-popup-categories-nested > div:nth-child(2) > div > div.didomi-components-accordion-label-container > div.didomi-consent-popup-data-processing__buttons > div > button:nth-child(1)"));
            DisAgreePersonalisedAdvert.Click();
            Sleep();

            //AgreePersonalisedAdvert
            IWebElement AgreePersonalisedAdvert = driver.FindElement(By.CssSelector("#didomi-consent-popup > div > div > div > div > div.didomi-consent-popup-body.didomi-popup-body > div:nth-child(2) > div.didomi-consent-popup-categories.didomi-consent-popup-categories-nested > div:nth-child(2) > div > div.didomi-components-accordion-label-container > div.didomi-consent-popup-data-processing__buttons > div > button:nth-child(2)"));
            AgreePersonalisedAdvert.Click();
            Sleep();

            //DisAgreePersonalData
            IWebElement DisAgreePersonalData = driver.FindElement(By.CssSelector("#didomi-consent-popup > div > div > div > div > div.didomi-consent-popup-body.didomi-popup-body > div:nth-child(2) > div.didomi-consent-popup-categories.didomi-consent-popup-categories-nested > div:nth-child(3) > div > div.didomi-components-accordion-label-container > div.didomi-consent-popup-data-processing__buttons > div > button:nth-child(1)"));
            DisAgreePersonalData.Click();
            Sleep();

            //AgreePersonalData
            IWebElement AgreePersonalData = driver.FindElement(By.CssSelector("#didomi-consent-popup > div > div > div > div > div.didomi-consent-popup-body.didomi-popup-body > div:nth-child(2) > div.didomi-consent-popup-categories.didomi-consent-popup-categories-nested > div:nth-child(3) > div > div.didomi-components-accordion-label-container > div.didomi-consent-popup-data-processing__buttons > div > button:nth-child(2)"));
            AgreePersonalData.Click();
            Sleep();

            //AgreeAll
            IWebElement AgreeAll = driver.FindElement(By.CssSelector("#didomi-radio-option-agree-to-all"));
            AgreeAll.Click();
            Sleep();

            //DisAgreeAll
            IWebElement DisAgreeAll = driver.FindElement(By.CssSelector("#didomi-radio-option-disagree-to-all"));
            DisAgreeAll.Click();
            Sleep();
        }

        [Test]
        public void ChooseAllPartners()
        {
            //ChooseAllPartners        
            IWebElement ChooseAllPartners = driver.FindElement(By.CssSelector("#didomi-consent-popup > div > div > div > div > div.didomi-consent-popup-body.didomi-popup-body > span > button"));
            ChooseAllPartners.Click();
            Sleep();

            //Disagreeallpartners
            IWebElement Disagreeallpartners1 = driver.FindElement(By.CssSelector("#didomi-consent-popup > div > div > div > div > div.didomi-consent-popup-body.didomi-popup-body > div.didomi-consent-popup-body__section > div.didomi-consent-popup-vendor.didomi-consent-popup-container-click-all > div.didomi-consent-popup-vendor__buttons > div > button.didomi-components-radio__option.didomi-components-radio__option--unselected"));
            Disagreeallpartners1.Click();
            Sleep();

            //Agreeallpartners
            IWebElement Agreeallpartners = driver.FindElement(By.CssSelector("#didomi-consent-popup > div > div > div > div > div.didomi-consent-popup-body.didomi-popup-body > div.didomi-consent-popup-body__section > div.didomi-consent-popup-vendor.didomi-consent-popup-container-click-all > div.didomi-consent-popup-vendor__buttons > div > button.didomi-components-radio__option.didomi-components-radio__option--selected.didomi-components-radio__option--agree"));
            Agreeallpartners.Click();
            Sleep();

            //Disagreeallpartners
            IWebElement Disagreeallpartners2 = driver.FindElement(By.CssSelector("#didomi-consent-popup > div > div > div > div > div.didomi-consent-popup-body.didomi-popup-body > div.didomi-consent-popup-body__section > div.didomi-consent-popup-vendor.didomi-consent-popup-container-click-all > div.didomi-consent-popup-vendor__buttons > div > button.didomi-components-radio__option.didomi-components-radio__option--unselected"));
            Disagreeallpartners2.Click();
            Sleep();
        }

        [Test]
        public void SelectParticularPartners()
        {
            //PlusXAGIABTCF
            //Agree
            IWebElement PlusXAGIABTCFAgree = driver.FindElement(By.XPath("//*[@id=\"didomi-consent-popup\"]/div/div/div/div/div[3]/div[1]/div[2]/div/div[2]/div[2]/div/button[2]"));
            PlusXAGIABTCFAgree.Click();
            Sleep();

            //DisAgree
            IWebElement PlusXAGIABTCFDisAgree = driver.FindElement(By.XPath("//*[@id=\"didomi-consent-popup\"]/div/div/div/div/div[3]/div[1]/div[2]/div/div[2]/div[2]/div/button[1]"));
            PlusXAGIABTCFDisAgree.Click();
            Sleep();

            //ExpandPanel
            IWebElement PlusXAGIABTCFExpandPanel = driver.FindElement(By.Id("didomi-vendor-92"));
            PlusXAGIABTCFExpandPanel.Click();
            Sleep();

            //CollapsePanel
            IWebElement PlusXAGIABTCFCollapsePanel = driver.FindElement(By.Id("didomi-vendor-92"));
            PlusXAGIABTCFCollapsePanel.Click();
            Sleep();

            //TappxIABTCF
            //Agree
            IWebElement TappxIABTCFAgree = driver.FindElement(By.XPath("//*[@id=\"didomi-consent-popup\"]/div/div/div/div/div[3]/div[1]/div[2]/div/div[4]/div[2]/div/button[2]"));
            TappxIABTCFAgree.Click();
            Sleep();

            //DisAgree
            IWebElement TappxIABTCFDisAgree = driver.FindElement(By.XPath("//*[@id=\"didomi-consent-popup\"]/div/div/div/div/div[3]/div[1]/div[2]/div/div[4]/div[2]/div/button[1]"));
            TappxIABTCFDisAgree.Click();
            Sleep();

            //ExpandPanel
            IWebElement TappxIABTCFExpandPanel = driver.FindElement(By.Id("didomi-vendor-628"));
            TappxIABTCFExpandPanel.Click();
            Sleep();

            //CollapsePanel
            IWebElement CollapsePanel = driver.FindElement(By.Id("didomi-vendor-628"));
            CollapsePanel.Click();
            Sleep();

            //InfoAboutUser
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
    }
}


        //Can not find element for now :-(
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





