using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace SlotokingUIAuto
{
    [TestFixture]
    public class AuthTests
    {
        [OneTimeSetUp]
        public void BeforeTestSuit() { }

        [SetUp]
        public void BeforeTest()
        {
            Driver.StartBrowser();
            Driver.Browser.Manage().Window.Maximize();
            Driver.Browser.Url = TestDataResource.MainPageURL;
        }

        [Test]
        public void Authorization_RestorePass_Negative()
        {
            HeaderButtons header = new HeaderButtons();
            VuePopup vue = new VuePopup();
            header.LoginButton.Click();
            vue.PhoneTabLogin.Click();
            vue.RestorePassButton.Click();
            vue.LoginSubmitButton.Click();

            StringAssert.AreEqualIgnoringCase("Поле Телефон обязательно для заполнения.", vue.LoginEmailErrorText.Text);
            
        }

        [Test]
        public void Authorization_RestorePassEmail_Positive()
        {
            VuePopup vue = new VuePopup();
            HeaderButtons header = new HeaderButtons();
            header.LoginButton.Click();
            vue.LoginEmailTextBox.Clear();
            vue.LoginEmailTextBox.SendKeys(TestDataResource.TestRestoreUserEmail);
            vue.RestorePassButton.Click();

            ///TODO добавить проверку почты           
        }

        [Test]
        public void Authorization_VKLogin_Positive()
        {
            HeaderButtons header = new HeaderButtons();
            VuePopup vue = new VuePopup();
            header.LoginButton.Click();
            vue.VKLoginButton.Click();

            SocialNetworkPages vk = new SocialNetworkPages();
            vk.VKLoginTextBox.SendKeys(TestDataResource.VKLogin);
            vk.VKPassTextBox.SendKeys(TestDataResource.VKPass);
            vk.VKLoginButton.Click();

            ProfilePage profile = new ProfilePage();
            StringAssert.Contains("ПРОФИЛЬ", profile.ProfileHeaderText.Text);
        }

        [Test]
        [Ignore ("not suport")]
        public void Authorization_FacebookLogin_Positive()
        {            
            HeaderButtons header = new HeaderButtons();
            VuePopup vue = new VuePopup();
            header.LoginButton.Click();
            vue.FacebookLoginButton.Click();

            SocialNetworkPages facebook = new SocialNetworkPages();
            facebook.FaceBookLoginTextBox.SendKeys(TestDataResource.FacebookLogin);
            facebook.FaceBookPassTextBox.SendKeys(TestDataResource.FacebookPass);
            facebook.FaceBookLoginButton.Click();

            ProfilePage profile = new ProfilePage();
            StringAssert.Contains("ПРОФИЛЬ", profile.ProfileHeaderText.Text);
        }

        [Test]
        public void Authorization_GoogleLogin_Positive()
        {
            VuePopup vue = new VuePopup();
            HeaderButtons header = new HeaderButtons();
            header.LoginButton.Click();
            vue.GoogleLoginButton.Click();

            SocialNetworkPages google = new SocialNetworkPages();
            google.GoogleLoginTextBox.SendKeys(TestDataResource.GoogleLogin);
            google.GoogleNextButton.Click();
            google.GooglePassTextBox.SendKeys(TestDataResource.GooglePass);
            google.GooglePassNextButton.Click();


            ProfilePage profile = new ProfilePage();
            StringAssert.Contains("ПРОФИЛЬ", profile.ProfileHeaderText.Text);
        }

        [Test]
        public void Authorization_OK_Positive()
        {
            VuePopup vue = new VuePopup();
            HeaderButtons header = new HeaderButtons();
            header.LoginButton.Click();
            vue.OKLoginButton.Click();

            SocialNetworkPages ok = new SocialNetworkPages();
            ok.OKLoginTextBox.SendKeys(TestDataResource.OkLogin);
            ok.OKPassTextBox.SendKeys(TestDataResource.OKPass);
            ok.OKLoginButton.Click();

            ProfilePage profile = new ProfilePage();
            StringAssert.Contains("ПРОФИЛЬ", profile.ProfileHeaderText.Text);
        }

        [Test]
        public void Authorization_MailRU_Positive()
        {
            VuePopup vue = new VuePopup();
            HeaderButtons header = new HeaderButtons();
            header.LoginButton.Click();
            vue.MailRULoginButton.Click();

            SocialNetworkPages mail = new SocialNetworkPages();
            mail.MailLoginTextBox.SendKeys(TestDataResource.MailRuLogin);
            mail.MailPassTextBox.SendKeys(TestDataResource.MailRUPass);
            mail.MailRULoginButton.Click();

            ProfilePage profile = new ProfilePage();
            StringAssert.Contains("ПРОФИЛЬ", profile.ProfileHeaderText.Text);
        }

        [Test]
        public void Authorization_Twitter_Positive()
        {
            VuePopup vue = new VuePopup();
            HeaderButtons header = new HeaderButtons();
            header.LoginButton.Click();
            vue.TwitterLoginButton.Click();

            SocialNetworkPages twitter = new SocialNetworkPages();
            twitter.TwitterLoginTextBox.SendKeys(TestDataResource.TwitterLogin);
            twitter.TwitterPassTextBox.SendKeys(TestDataResource.TwitterPass);
            twitter.TwitterLoginButton.Click();

            ProfilePage profile = new ProfilePage();
            StringAssert.Contains("ПРОФИЛЬ", profile.ProfileHeaderText.Text);
        }

        [Test]
        public void Authorization_RestorePassPhone_Positive()
        {
            VuePopup vue = new VuePopup();
            HeaderButtons header = new HeaderButtons();
            header.LoginButton.Click();
            vue.PhoneTabLogin.Click();
            vue.LoginPhoneTextBox.Clear();
            vue.LoginPhoneTextBox.SendKeys(TestDataResource.TestRestoreUserPhone);
            vue.RestorePassButton.Click();

            ///TODO добавить проверку почты           
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
