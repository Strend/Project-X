using System;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;

namespace SlotokingUIAuto
{
    [TestFixture]
    public class RegistrationTests
    {
        [OneTimeSetUp]
        public void BeforeTestSuit() { }

        [SetUp]
        public void BeforeTest()
        {
            Driver.StartBrowser();
            Driver.Browser.Manage().Window.Maximize();
            //Driver.Browser.Url = TestDataResource.MainPageURL;
        }

        [Test]
        public void Registration_ByEmail_Positive()
        {
            Random rnd = new Random();            
            VuePopup vue = new VuePopup();
            HeaderButtons hdr = new HeaderButtons();
            vue.Registration(false);
            StringAssert.AreEqualIgnoringCase("Профиль", hdr.ProfileLink.Text);
        }

        [Test]
        public void Registration_ByPhone_Positive()
        {
            Random rnd = new Random();            
            VuePopup vue = new VuePopup();
            HeaderButtons hdr = new HeaderButtons();
            vue.Registration(true);
            StringAssert.AreEqualIgnoringCase("Профиль", hdr.ProfileLink.Text);
        }

        [TearDown]
        public void AfterTest()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                Driver.TakeScreenshot("");
            }
            Driver.DisposeBrowser();
        }

        [OneTimeTearDown]
        public void AfterTestSuit() { }
    }  
}
