using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;

namespace SlotokingUIAuto
{
    [TestFixture]
    class KingMainPageTests
    {
        [OneTimeSetUp]
        public void BeforeTestSuit() { }

        [SetUp]
        public void BeforeTest()
        {
            Driver.StartBrowser();
            Driver.Browser.Manage().Window.Maximize();
        }

        [Test]
        public void Screenshot_MailnPage_LoggedIn()
        {
            VuePopup vue = new VuePopup();
            vue.Auth(TestDataResource.TestUserEmail, false);

            Driver.TakeScreenshot("JHJKJH");
        }

        [Test]
        public void Screenshot_MailnPage_LoggedOut()
        {
            Driver.Browser.Url = TestDataResource.MainPageURL;
            Driver.TakeScreenshot("JHJKJH");

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
