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

        }

        public void Sleep()
        {
            
            Thread.Sleep(500);
        }

        [Test]
        public void DisagreeWebCookies()
        {
            driver.Navigate().GoToUrl("https://idnes.cz");

            //MoreInfoAboutCookies
            driver.FindElement(By.CssSelector("#didomi-notice-learn-more-button")).Click();
            Sleep();

            //DisAgreeDeviceInfo
            driver.FindElement(By.CssSelector("#didomi-consent-popup > div > div > div > div > div.didomi-consent-popup-body.didomi-popup-body > div:nth-child(2) > div.didomi-consent-popup-categories.didomi-consent-popup-categories-nested > div:nth-child(1) > div > div.didomi-consent-popup-data-processing__buttons.didomi-consent-popup-data-processing__buttons_tcf_v2 > div > button:nth-child(1)")).Click();
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
        public void ShowOurPartners()
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

            //Agree1PlusIABTCF
            driver.FindElement(By.CssSelector("#didomi-consent-popup > div > div > div > div > div.didomi-consent-popup-body.didomi-popup-body > div.didomi-consent-popup-body__section > div.didomi-consent-popup-body_vendors-list > div > div:nth-child(2) > div.didomi-consent-popup-vendor__buttons > div > button.didomi-components-radio__option.didomi-components-radio__option--selected.didomi-components-radio__option--agree")).Click();
            
            //DisAgreeIABTCF
            driver.FindElement(By.CssSelector("#didomi-consent-popup > div > div > div > div > div.didomi-consent-popup-body.didomi-popup-body > div.didomi-consent-popup-body__section > div.didomi-consent-popup-body_vendors-list > div > div:nth-child(2) > div.didomi-consent-popup-vendor__buttons > div > button.didomi-components-radio__option.didomi-components-radio__option--unselected")).Click();
            Sleep();

            //AgreeTappxIABTCF
            driver.FindElement(By.CssSelector("#didomi-consent-popup > div > div > div > div > div.didomi-consent-popup-body.didomi-popup-body > div.didomi-consent-popup-body__section > div.didomi-consent-popup-body_vendors-list > div > div:nth-child(4) > div.didomi-consent-popup-vendor__buttons > div > button.didomi-components-radio__option.didomi-components-radio__option--unselected")).Click();
            
            //DisAgreeTappxIABTCF
            driver.FindElement(By.CssSelector("#didomi-consent-popup > div > div > div > div > div.didomi-consent-popup-body.didomi-popup-body > div.didomi-consent-popup-body__section > div.didomi-consent-popup-body_vendors-list > div > div:nth-child(4) > div.didomi-consent-popup-vendor__buttons > div > button.didomi-components-radio__option.didomi-components-radio__option--selected.didomi-components-radio__option--disagree")).Click();
            /*driver.FindElement(By.CssSelector("")).Click();
            driver.FindElement(By.CssSelector("")).Click();
            driver.FindElement(By.CssSelector("")).Click();
            driver.FindElement(By.CssSelector("")).Click();
            driver.FindElement(By.CssSelector("")).Click();
            driver.FindElement(By.CssSelector("")).Click();
            driver.FindElement(By.CssSelector("")).Click();
            driver.FindElement(By.CssSelector("")).Click();
            driver.FindElement(By.CssSelector("")).Click();
            driver.FindElement(By.CssSelector("")).Click();
            driver.FindElement(By.CssSelector("")).Click();
            driver.FindElement(By.CssSelector("")).Click();
            driver.FindElement(By.CssSelector("")).Click();
            driver.FindElement(By.CssSelector("")).Click();
            driver.FindElement(By.CssSelector("")).Click();
            driver.FindElement(By.CssSelector("")).Click();
            driver.FindElement(By.CssSelector("")).Click();
            driver.FindElement(By.CssSelector("")).Click();
            driver.FindElement(By.CssSelector("")).Click();
            
            //ConfirmMyChoice
             driver.FindElement(By.CssSelector("#didomi-consent-popup > div > div > div > div > div.didomi-consent-popup-footer.didomi-popup-footer > div > button")).Click();
             Sleep();*/
        }

        /*public void MainLogin()
        {
            driver.FindElement(By.CssSelector("#portalogin-link")).Click();
            Thread.Sleep(2000);*/

    }

    }
