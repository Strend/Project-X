//using System;
//using System.IO;
//using System.Configuration;
//using OpenQA.Selenium.Appium.Enums;
//using NUnit.Framework;
//using OpenQA.Selenium.Appium;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Appium.iOS;
//using SlotokingUIAuto.Pages;
//using OpenQA.Selenium.Remote;

//namespace TestAppium
//{
//    [TestFixture]
//    public class Test
//    {
//        AppiumDriver<IWebElement> driver;

//        [SetUp()]
//        public void StartDriver()
//        {
//            String dirPath = ConfigurationManager.AppSettings["DirectoryPath"];
//            string fileName = string.Format("{0}{1}", Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"../../")), dirPath);
//            DesiredCapabilities capabilities = new DesiredCapabilities();
//            capabilities.SetCapability("deviceName", "iphone X");
//            capabilities.SetCapability("automationName", "test");
//            capabilities.SetCapability("platformName", "iOS");
//            capabilities.SetCapability(MobileCapabilityType.BrowserName, "Browser");


//            driver = new IOSDriver<IWebElement>(new Uri("http://127.0.0.1:4723/wd/hub"), capabilities);
//        }

//        [Test]
//        public void Test1()
//        {

//            driver.FindElement(AppLocators.addButton).Click();

//            IWebElement textbox = driver.FindElement(AppLocators.textBox);
//            textbox.SendKeys("First Element");


//            driver.FindElement(AppLocators.saveButton).Click();


//            Assert.AreEqual("First Element", driver.FindElement(AppLocators.listElement).Text);

//        }

//        [TearDown()]
//        public void CloseDriver()
//        {
//            driver.Quit();
//        }
//    }
//}


