using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;
using SlotokingUIAuto;
using SlotokingUIAuto.Pages;
using System;
using System.Net;

namespace MobileTesting
{
    [TestFixture()]
    public class TestAppium
    {

        public void AfterAll()
        { }



        [OneTimeSetUp]
        public void BeforeTestSuit() { }

        [SetUp]
        public void BeforeTest()
        {
            Driver.StartDeviceAndroid();
            Driver.Browser.Url = TestDataResource.MainPageURL;
        }



        [Test]
        [Ignore("Тест моб орієнтація")]
        public void OpenHofHomePage()
        {
            Driver.Browser.FindElement(By.XPath("//*[@id='wrapper']/div[2]/div[2]/div[1]/a/i")).Click();
        }


        [Test]
        [Ignore("Тест моб орієнтація")]
        public void OrientationTest()
        {
            IRotatable rotatable = ((IRotatable)Driver.Browser);
            rotatable.Orientation = ScreenOrientation.Portrait;
            Assert.AreEqual(ScreenOrientation.Portrait, rotatable.Orientation);
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
    }
}