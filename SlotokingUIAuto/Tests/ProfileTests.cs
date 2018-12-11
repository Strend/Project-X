using System;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;

namespace SlotokingUIAuto
{
    [TestFixture]
    public class ProfileTests
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
        public void Profile_FillTitle()
        {           
            VuePopup vue = new VuePopup();            
            Random rnd = new Random();
            vue.Registration(true);
            vue.CloseWizzardPopup.Click();
            Driver.Browser.Url = TestDataResource.MainPageURL + "/profile/account/";            

            Profile_AccountPage account = new Profile_AccountPage();
            account.NameTextBox.SendKeys(TestDataResource.UserName);
            account.SurnameTextBox.SendKeys(TestDataResource.UserSurname);
            account.NicknameTextBox.SendKeys(TestDataResource.UserNickname);
            account.MaleGenderRadioButton.Click();
            account.FillDate();
            account.SaveTitleButton.Click();

            Assert.IsTrue(account.SuccessSaveMessage.Displayed);
        }

        [Test]
        public void Profile_FillPhone()
        {
            VuePopup vue = new VuePopup();
            Random rnd = new Random();
            vue.Registration(false);
            vue.CloseWizzardPopup.Click();
            Driver.Browser.Url = TestDataResource.MainPageURL + "/profile/account/";

            Profile_AccountPage account = new Profile_AccountPage();
            account.PlayerPhoneTextBox.SendKeys("500508" + rnd.Next(100, 999).ToString());
            account.SavePhoneButton.Click();

            Assert.IsTrue(account.SuccessSaveMessage.Displayed);
        }

        [Test]
        //[Ignore ("not complited")]
        public void Profile_FillPersonalInfo()
        {
            VuePopup vue = new VuePopup();
            Random rnd = new Random();
            vue.Registration(false);
            vue.CloseWizzardPopup.Click();
            Driver.Browser.Url = TestDataResource.MainPageURL + "/profile/account/";

            Profile_AccountPage account = new Profile_AccountPage();
            account.ChooseCountry();
            account.CityTextBox.SendKeys("Kyiv");
            account.AddressListBox.SendKeys("23007 Ukraine, Kyiv, Hreschatic 25/12");
            account.SavePersonalInfoButton.Click();

            Assert.IsTrue(account.SuccessSaveMessage.Displayed);
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
