using IdnesCZ.Setup;
using IdnesCZ.Utilities;

namespace IdnesCZ.Tests;

    public class TestCookies : ElementsAndThreadSleep
    {
        public IWebDriver webDriver = new WebDriverSetup("Chrome").GetWebDriver();

        [SetUp]
        public void tSleep()
        {
            Thread.Sleep(1000);
        }

        public void BrowserSetup()
        {
            webDriver.Manage().Window.Size.Width.Equals(1920);
            webDriver.Manage().Window.Size.Height.Equals(1080);
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

    [TestCase]
    public void DisagreeWebCookies()
    {
        //Go to "Idnes" website
        GoToWebSite("");

        //MoreInfoAboutCookies
        ClickOnCssSelectorElement("#didomi-notice-learn-more-button");
        //webDriver.FindElement(By.CssSelector("#didomi-notice-learn-more-button")).Click();
        Console.Write("MoreInfoAboutCookies Done");

        //DisAgreeDeviceInfo
        ClickOnCssSelectorElement("#didomi-consent-popup > div > div > div > div > div.didomi-consent-popup-body.didomi-popup-body > div:nth-child(2) > div.didomi-consent-popup-categories.didomi-consent-popup-categories-nested > div:nth-child(1) > div > div.didomi-consent-popup-data-processing__buttons.didomi-consent-popup-data-processing__buttons_tcf_v2 > div > button:nth-child(1)");
        tSleep();

        //AgreeDeviceInfo
        ClickOnCssSelectorElement("#didomi-consent-popup > div > div > div > div > div.didomi-consent-popup-body.didomi-popup-body > div:nth-child(2) > div.didomi-consent-popup-categories.didomi-consent-popup-categories-nested > div:nth-child(1) > div > div.didomi-consent-popup-data-processing__buttons.didomi-consent-popup-data-processing__buttons_tcf_v2 > div > button:nth-child(2)");
        tSleep();

        //DisAgreePersonalisedAdvert
        ClickOnCssSelectorElement("#didomi-consent-popup > div > div > div > div > div.didomi-consent-popup-body.didomi-popup-body > div:nth-child(2) > div.didomi-consent-popup-categories.didomi-consent-popup-categories-nested > div:nth-child(2) > div > div.didomi-components-accordion-label-container > div.didomi-consent-popup-data-processing__buttons > div > button:nth-child(1)");
        tSleep();

        //AgreePersonalisedAdvert
        ClickOnCssSelectorElement("#didomi-consent-popup > div > div > div > div > div.didomi-consent-popup-body.didomi-popup-body > div:nth-child(2) > div.didomi-consent-popup-categories.didomi-consent-popup-categories-nested > div:nth-child(2) > div > div.didomi-components-accordion-label-container > div.didomi-consent-popup-data-processing__buttons > div > button:nth-child(2)");
        tSleep();

        //DisAgreePersonalData
        ClickOnCssSelectorElement("#didomi-consent-popup > div > div > div > div > div.didomi-consent-popup-body.didomi-popup-body > div:nth-child(2) > div.didomi-consent-popup-categories.didomi-consent-popup-categories-nested > div:nth-child(3) > div > div.didomi-components-accordion-label-container > div.didomi-consent-popup-data-processing__buttons > div > button:nth-child(1)");
        tSleep();

        //AgreePersonalData
        ClickOnCssSelectorElement("#didomi-consent-popup > div > div > div > div > div.didomi-consent-popup-body.didomi-popup-body > div:nth-child(2) > div.didomi-consent-popup-categories.didomi-consent-popup-categories-nested > div:nth-child(3) > div > div.didomi-components-accordion-label-container > div.didomi-consent-popup-data-processing__buttons > div > button:nth-child(2)");
        tSleep();

        //AgreeAll
        ClickOnCssSelectorElement("#didomi-radio-option-agree-to-all");
        tSleep();

        //DisAgreeAll
        webDriver.FindElement(By.CssSelector("#didomi-radio-option-disagree-to-all")).Click();
        tSleep();
    }

    [Test]
    public void ChooseAllPartners()
    {
        ClickOnCssSelectorElement("#didomi-consent-popup > div > div > div > div > div.didomi-consent-popup-body.didomi-popup-body > span > button");
        tSleep();

        //Disagreeallpartners            
        ClickOnCssSelectorElement("#didomi-consent-popup > div > div > div > div > div.didomi-consent-popup-body.didomi-popup-body > div.didomi-consent-popup-body__section > div.didomi-consent-popup-vendor.didomi-consent-popup-container-click-all > div.didomi-consent-popup-vendor__buttons > div > button.didomi-components-radio__option.didomi-components-radio__option--unselected");
        tSleep();

        //Agreeallpartners
        ClickOnCssSelectorElement("#didomi-consent-popup > div > div > div > div > div.didomi-consent-popup-body.didomi-popup-body > div.didomi-consent-popup-body__section > div.didomi-consent-popup-vendor.didomi-consent-popup-container-click-all > div.didomi-consent-popup-vendor__buttons > div > button.didomi-components-radio__option.didomi-components-radio__option--selected.didomi-components-radio__option--agree");
        tSleep();

        //Disagreeallpartners            
        ClickOnCssSelectorElement("#didomi-consent-popup > div > div > div > div > div.didomi-consent-popup-body.didomi-popup-body > div.didomi-consent-popup-body__section > div.didomi-consent-popup-vendor.didomi-consent-popup-container-click-all > div.didomi-consent-popup-vendor__buttons > div > button.didomi-components-radio__option.didomi-components-radio__option--unselected");
        tSleep();
    }

    [Test]
    public void PlusXAGIABTCF()
    {
        //Agree
        webDriver.FindElement(By.XPath("//*[@id=\"didomi-consent-popup\"]/div/div/div/div/div[3]/div[1]/div[2]/div/div[2]/div[2]/div/button[2]")).Click();
        tSleep();

        //DisAgree
        webDriver.FindElement(By.XPath("//*[@id=\"didomi-consent-popup\"]/div/div/div/div/div[3]/div[1]/div[2]/div/div[2]/div[2]/div/button[1]")).Click();
        tSleep();

        //ExpandPanel
        webDriver.FindElement(By.Id("didomi-vendor-92")).Click();
        tSleep();

        //CollapsePanel
        webDriver.FindElement(By.Id("didomi-vendor-92")).Click();
        tSleep();
    }

    [Test]
    public void TappxIABTCF()
    {
        //Agree
        webDriver.FindElement(By.XPath("//*[@id=\"didomi-consent-popup\"]/div/div/div/div/div[3]/div[1]/div[2]/div/div[4]/div[2]/div/button[2]")).Click();
        tSleep();

        //DisAgree
        webDriver.FindElement(By.XPath("//*[@id=\"didomi-consent-popup\"]/div/div/div/div/div[3]/div[1]/div[2]/div/div[4]/div[2]/div/button[1]")).Click();
        tSleep();

        //ExpandPanel
        webDriver.FindElement(By.Id("didomi-vendor-628")).Click();
        tSleep();

        //CollapsePanel
        webDriver.FindElement(By.Id("didomi-vendor-628")).Click();
        tSleep();
    }

    [Test]
    public void InfoAboutUser()
    {
        //ExpandInfoAboutUser
        IWebElement ExpandInfoAboutUser = webDriver.FindElement(By.XPath("//*[@id=\"didomi-consent-popup\"]/div/div/div/div/div[3]/div[2]/div/div[1]/div"));
        ExpandInfoAboutUser.Click();
        tSleep();

        //CollapseInfoAboutUser
        IWebElement CollapseInfoAboutUser = webDriver.FindElement(By.XPath("//*[@id=\"didomi-consent-popup\"]/div/div/div/div/div[3]/div[2]/div/div[1]/div"));
        CollapseInfoAboutUser.Click();
        tSleep();

        IWebElement AgreeMyChoices = webDriver.FindElement(By.XPath("//*[@id=\"didomi-consent-popup\"]/div/div/div/div/div[4]/div/button"));
        AgreeMyChoices.Click();
        tSleep();

        IWebElement AgreeMyChoicesCookies = webDriver.FindElement(By.XPath("//*[@id=\"didomi-consent-popup\"]/div/div/div/div/div[4]/div/button"));
        AgreeMyChoicesCookies.Click();
        tSleep();
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


