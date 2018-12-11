using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using SlotokingUIAuto;
using System;

namespace AllGamesRun
{
    [TestFixture]
    public class AllGamesRuns
    {
        GamePage games;
        VuePopup vue;
        HeaderButtons header;
        string login = "amys@cleack.com";
        const int DELAY = 10000;


        [SetUp]
        public void BeforeTest()
        {
            Driver.StartBrowser();
            Driver.Browser.Manage().Window.Maximize();
            games = new GamePage();
            vue = new VuePopup();
            header = new HeaderButtons();
        }

        [Test]
        public void Novomatic_BookOfRa()
        {
            vue.Auth(login, false);
            header.GamesLnk.Click();
            games.NovomaticButton.Click();

            games.MoveCursorToGame(games.BookOfRaImage);
            games.BookOfRaPlay.Click();
            System.Threading.Thread.Sleep(6000);
            double balance = Convert.ToDouble(games.BalanceTextPartners.Text.Substring(0, games.BalanceTextPartners.Text.IndexOf(' ')));

            System.Threading.Thread.Sleep(DELAY);
            games.ButtonClick(games.GameContainer, 693, 740);
            System.Threading.Thread.Sleep(1000);
            games.BalanceTextPartners.Click();
            Assert.AreNotEqual(balance, Convert.ToDouble(games.BalanceTextPartners.Text.Substring(0, games.BalanceTextPartners.Text.IndexOf(' '))));
        }

        [Test]
        public void Igrosoft_CrazyMonkey()
        {
            vue.Auth(login, false);
            header.GamesLnk.Click();
            games.IgrosoftButton.Click();

            games.MoveCursorToGame(games.FirstGameImage);
            games.FirstGamePlayButton.Click();
            System.Threading.Thread.Sleep(3000);
            double balance = Convert.ToDouble(games.BalanceTextPartners.Text.Substring(0, games.BalanceTextPartners.Text.IndexOf(' ')));

            System.Threading.Thread.Sleep(DELAY);
            games.ButtonClick(games.PartnersGameContainer, 850, 750);
            System.Threading.Thread.Sleep(2000);
            games.LongKeyDown(games.PartnersGameContainer, 850, 750);
            System.Threading.Thread.Sleep(2000);
            games.LongKeyDown(games.PartnersGameContainer, 850, 750);
            System.Threading.Thread.Sleep(2000);
            games.BalanceTextPartners.Click();
            Assert.AreNotEqual(balance, Convert.ToDouble(games.BalanceTextPartners.Text.Substring(0, games.BalanceTextPartners.Text.IndexOf(' '))));
        }

        [Test]
        public void King_DiscoFuits()
        {
            vue.Auth(login, false);
            header.GamesLnk.Click();
            games.KingButton.Click();

            games.MoveCursorToGame(games.FirstGameImage);
            games.FirstGamePlayButton.Click();
            System.Threading.Thread.Sleep(5000);
            double balance = Convert.ToDouble(games.BalanceTextPartners.Text.Substring(0, games.BalanceTextPartners.Text.IndexOf(' ')));

            System.Threading.Thread.Sleep(DELAY);
            games.ButtonClick(games.GameContainer, 1160, 725);
            System.Threading.Thread.Sleep(5000);
            games.ButtonClick(games.GameContainer, 1160, 725);

            System.Threading.Thread.Sleep(3000);
            games.BalanceTextPartners.Click();
            games.ButtonClick(games.GameContainer, 1160, 725);
            System.Threading.Thread.Sleep(3000);
            games.BalanceTextPartners.Click();
            games.ButtonClick(games.GameContainer, 1160, 725);
            System.Threading.Thread.Sleep(3000);
            games.BalanceTextPartners.Click();
            Assert.AreNotEqual(balance, Convert.ToDouble(games.BalanceTextPartners.Text.Substring(0, games.BalanceTextPartners.Text.IndexOf(' '))));
        }

        [Test]
        [Ignore("")]
        public void Ezugi_Baccarat()
        {
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("--disable-features=EnableEphemeralFlashPermission");
            chromeOptions.AddUserProfilePreference("profile.content_settings.exceptions.plugins.*, *.setting", 1);
            chromeOptions.AddUserProfilePreference("profile.default_content_setting_values.plugins", 1);
            chromeOptions.AddUserProfilePreference("profile.content_settings.plugin_whitelist.adobe - flash - player", 1);



            vue.Auth(login, false);
            header.GamesLnk.Click();

            games.EzugiButton.Click();
            games.MoveCursorToGame(games.FirstGameImage);
            //System.Threading.Thread.Sleep(3000);
            games.MoveCursorToGame(games.FirstGameImage);
            games.FirstGamePlayButton.Click();


            double balance = Convert.ToDouble(games.BalanceTextPartners.Text.Substring(0, games.BalanceTextPartners.Text.IndexOf(' ')));

            System.Threading.Thread.Sleep(DELAY);
            games.ButtonClick(games.PartnersGameContainer, 200, 200);
            System.Threading.Thread.Sleep(10000);
            //OneSignal signal = new OneSignal();
            //if (signal.CancelButton.Displayed) signal.CancelButton.Click();
            games.ButtonClick(games.PartnersGameContainer, 500, 650);
            System.Threading.Thread.Sleep(4000);
            games.BalanceTextPartners.Click();
            games.ButtonClick(games.PartnersGameContainer, 500, 650);
            System.Threading.Thread.Sleep(4000);
            games.BalanceTextPartners.Click();
            games.ButtonClick(games.PartnersGameContainer, 500, 650);
            System.Threading.Thread.Sleep(4000);
            games.BalanceTextPartners.Click();
            games.ButtonClick(games.PartnersGameContainer, 500, 650);
            System.Threading.Thread.Sleep(4000);
            games.BalanceTextPartners.Click();
            games.ButtonClick(games.PartnersGameContainer, 500, 650);
            System.Threading.Thread.Sleep(4000);
            games.BalanceTextPartners.Click();
            games.ButtonClick(games.PartnersGameContainer, 500, 650);
            System.Threading.Thread.Sleep(4000);
            games.BalanceTextPartners.Click();
            games.ButtonClick(games.PartnersGameContainer, 500, 650);
            System.Threading.Thread.Sleep(4000);
            games.BalanceTextPartners.Click();
            Assert.AreNotEqual(balance, Convert.ToDouble(games.BalanceTextPartners.Text.Substring(0, games.BalanceTextPartners.Text.IndexOf(' '))));
        }

        [Test]
        public void Quickspin_StickyBandits()
        {
            vue.Auth(login, false);
            header.GamesLnk.Click();
            games.QuickspinButton.Click();

            games.MoveCursorToGame(games.FirstGameImage);
            games.FirstGamePlayButton.Click();
            System.Threading.Thread.Sleep(5000);
            double balance = Convert.ToDouble(games.BalanceTextPartners.Text.Substring(0, games.BalanceTextPartners.Text.IndexOf(' ')));

            System.Threading.Thread.Sleep(DELAY);
            games.ButtonClick(games.PartnersGameContainer, 666, 666);
            System.Threading.Thread.Sleep(3000);
            games.ButtonClick(games.PartnersGameContainer, 680, 400);
            System.Threading.Thread.Sleep(3000);
            games.ButtonClick(games.PartnersGameContainer, 680, 400);
            System.Threading.Thread.Sleep(3000);
            games.ButtonClick(games.PartnersGameContainer, 1150, 730);
            System.Threading.Thread.Sleep(3000);
            games.ButtonClick(games.PartnersGameContainer, 1150, 730);
            System.Threading.Thread.Sleep(3000);
            games.BalanceTextPartners.Click();
            Assert.AreNotEqual(balance, Convert.ToDouble(games.BalanceTextPartners.Text.Substring(0, games.BalanceTextPartners.Text.IndexOf(' '))));
        }

        [Test]
        public void Elk_Birthday()
        {
            vue.Auth(login, false);
            header.GamesLnk.Click();
            games.ElkButton.Click();

            games.MoveCursorToGame(games.FirstGameImage);
            games.FirstGamePlayButton.Click();
            double balance = Convert.ToDouble(games.BalanceTextPartners.Text.Substring(0, games.BalanceTextPartners.Text.IndexOf(' ')));
            System.Threading.Thread.Sleep(3000);
            System.Threading.Thread.Sleep(DELAY);
            games.ButtonClick(games.PartnersGameContainer, 693, 390);
            System.Threading.Thread.Sleep(5000);
            games.ButtonClick(games.PartnersGameContainer, 1200, 600);
            System.Threading.Thread.Sleep(4000);
            games.ButtonClick(games.PartnersGameContainer, 1200, 600);
            System.Threading.Thread.Sleep(4000);
            games.ButtonClick(games.PartnersGameContainer, 1200, 600);
            System.Threading.Thread.Sleep(4000);
            games.BalanceTextPartners.Click();
            System.Threading.Thread.Sleep(2000);
            Assert.AreNotEqual(balance, Convert.ToDouble(games.BalanceTextPartners.Text.Substring(0, games.BalanceTextPartners.Text.IndexOf(' '))));
        }

        [Test]
        public void Thunderkick_PinkElephants()
        {
            vue.Auth(login, false);
            header.GamesLnk.Click();
            games.ThunderkickButton.Click();

            games.MoveCursorToGame(games.FirstGameImage);
            games.FirstGamePlayButton.Click();
            System.Threading.Thread.Sleep(5000);
            double balance = Convert.ToDouble(games.BalanceTextPartners.Text.Substring(0, games.BalanceTextPartners.Text.IndexOf(' ')));
            System.Threading.Thread.Sleep(DELAY);
            games.ButtonClick(games.PartnersGameContainer, 1300, 650);
            System.Threading.Thread.Sleep(4000);
            games.ButtonClick(games.PartnersGameContainer, 1300, 650);
            System.Threading.Thread.Sleep(4000);
            games.ButtonClick(games.PartnersGameContainer, 1300, 650);
            System.Threading.Thread.Sleep(4000);
            games.ButtonClick(games.PartnersGameContainer, 1300, 650);
            System.Threading.Thread.Sleep(4000);
            games.BalanceTextPartners.Click();
            Assert.AreNotEqual(balance, Convert.ToDouble(games.BalanceTextPartners.Text.Substring(0, games.BalanceTextPartners.Text.IndexOf(' '))));
        }

        [Test]
        public void Spinomenal_BookOfGuardians()
        {
            vue.Auth(login, false);
            header.GamesLnk.Click();
            games.SpinomenalButton.Click();

            games.MoveCursorToGame(games.FirstGameImage);
            games.FirstGamePlayButton.Click();
            System.Threading.Thread.Sleep(5000);
            double balance = Convert.ToDouble(games.BalanceTextPartners.Text.Substring(0, games.BalanceTextPartners.Text.IndexOf(' ')));

            System.Threading.Thread.Sleep(DELAY);
            games.ButtonClick(games.PartnersGameContainer, 700, 600);
            System.Threading.Thread.Sleep(3000);
            games.ButtonClick(games.PartnersGameContainer, 675, 675);
            System.Threading.Thread.Sleep(1000);
            games.ButtonClick(games.PartnersGameContainer, 675, 675);
            System.Threading.Thread.Sleep(3000);
            games.BalanceTextPartners.Click();
            Assert.AreNotEqual(balance, Convert.ToDouble(games.BalanceTextPartners.Text.Substring(0, games.BalanceTextPartners.Text.IndexOf(' '))));
        }

        [Test]
        [Ignore("")]
        public void TomHorn_JokerPoker()
        {
            vue.Auth(login, false);
            header.GamesLnk.Click();
            games.TomHornButton.Click();

            games.MoveCursorToGame(games.FirstGameImage);
            games.FirstGamePlayButton.Click();
            System.Threading.Thread.Sleep(3000);
            double balance = Convert.ToDouble(games.BalanceTextPartners.Text.Substring(0, games.BalanceTextPartners.Text.IndexOf(' ')));
            System.Threading.Thread.Sleep(DELAY);
            games.ButtonClick(games.Tom_HornGameContainer, 950, 730);
            System.Threading.Thread.Sleep(2000);
            games.ButtonClick(games.Tom_HornGameContainer, 950, 730);
            System.Threading.Thread.Sleep(2000);
            games.ButtonClick(games.Tom_HornGameContainer, 700, 730);
            System.Threading.Thread.Sleep(2000);
            games.ButtonClick(games.Tom_HornGameContainer, 700, 730);
            System.Threading.Thread.Sleep(2000);
            games.ButtonClick(games.Tom_HornGameContainer, 700, 730);
            System.Threading.Thread.Sleep(2000);
            games.ButtonClick(games.Tom_HornGameContainer, 700, 730);
            games.BalanceTextPartners.Click();
            Assert.AreNotEqual(balance, Convert.ToDouble(games.BalanceTextPartners.Text.Substring(0, games.BalanceTextPartners.Text.IndexOf(' '))));
        }

        [Test]
        [Ignore("not complited")]
        public void DemoGameRun_Positive()
        {
            Driver.Browser.Url = TestDataResource.MainPageURL + "/games/all-slots/";
            GamePage games = new GamePage();
            HeaderButtons header = new HeaderButtons();

            var startSize = new System.Drawing.Size(1400, 800);
            games.ReturnFocus();
            games.FullscrinButtonClick();

            if (games.CalcContainerSize().Height > startSize.Height)
            {
                Assert.Pass();
                return;
            }
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



