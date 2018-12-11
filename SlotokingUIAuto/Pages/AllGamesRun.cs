using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SlotokingUIAuto;

namespace AllGamesRun
{
    class GamePage
    {
        public IWebElement GameContainer => Driver.WaitUntilVisible(By.XPath("//*[@id='main-game-frame']"));

        public IWebElement PartnersGameContainer => Driver.WaitUntilVisible(By.XPath("//*[@id='casinoClient']"));
        public IWebElement PartnersGameContainer777 => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[2]/div/div[1]/iframe"));
        public IWebElement PartnersGameContainerVIP => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[5]/div[1]/div/div[1]/iframe"));
        public IWebElement Tom_HornGameContainer => Driver.WaitUntilVisible(By.XPath("//*[@id='gameInnerPlaceholder']"));                                                                              //*[@id="gameInnerPlaceholder"]
        public IWebElement FirstGameImage => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[4]/div[2]/div[3]/div[1]"));
        public IWebElement FirstGameImage777 => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[3]/div/div/div[4]/div/div[1]/div"));
        public IWebElement FirstGameImageVIP => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[5]/div/div[3]/div/div[1]/img"));
        public IWebElement FirstGamePlayButton => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[4]/div[2]/div[3]/div[1]/div/span[1]"));
        public IWebElement FirstGamePlayButton777 => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[3]/div/div/div[4]/div/div[1]/div/div/a[1]"));
        public IWebElement FirstGamePlayButtonVIP => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[5]/div/div[3]/div/div[1]/div/a[1]"));
        public IWebElement StartDemoGameButton => Driver.WaitUntilVisible(By.XPath("//*[@id='startDemoGame']"));
        public IWebElement BalanceText => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[3]/div/div[1]/div[4]/div[1]/span/acv"));

        
        public IWebElement BalanceTextPartners => Driver.WaitUntilVisible(By.XPath("//*[@id='vuePopup']/div[5]/div[2]/div[3]/div[2]/div[1]/div/div[1]/div[2]"));
        public IWebElement BalanceTextPartners777 => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[2]/div/div[2]/div[3]/div[1]/span"));
        public IWebElement BalanceTextPartnersVIP => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[3]/div[1]/div[2]/div[1]/span[2]/acv[1]"));
        public IWebElement ProgressBar => Driver.WaitUntilVisible(By.XPath("//*[@id='progress-bar']"));

        /// King game providers buttons
        public IWebElement NovomaticButton => Driver.WaitUntilVisible(By.XPath("//*[@id='tags-container']/div/div[1]/div/ul/li[1]/a"));
        public IWebElement IgrosoftButton => Driver.WaitUntilVisible(By.XPath("//*[@id='tags-container']/div/div[1]/div/ul/li[2]/a"));
        public IWebElement KingButton => Driver.WaitUntilVisible(By.XPath("//*[@id='tags-container']/div/div[1]/div/ul/li[3]/a"));
        public IWebElement EzugiButton => Driver.WaitUntilVisible(By.XPath("//*[@id='tags-container']/div/div[1]/div/ul/li[4]/a"));
        public IWebElement QuickspinButton => Driver.WaitUntilVisible(By.XPath("//*[@id='tags-container']/div/div[1]/div/ul/li[5]/a"));
        public IWebElement ElkButton => Driver.WaitUntilVisible(By.XPath("//*[@id='tags-container']/div/div[1]/div/ul/li[6]/a"));
        public IWebElement ThunderkickButton => Driver.WaitUntilVisible(By.XPath("//*[@id='tags-container']/div/div[1]/div/ul/li[7]/a"));
        public IWebElement SpinomenalButton => Driver.WaitUntilVisible(By.XPath("//*[@id='tags-container']/div/div[1]/div/ul/li[8]/a"));
        public IWebElement TomHornButton => Driver.WaitUntilVisible(By.XPath("//*[@id='tags-container']/div/div[1]/div/ul/li[9]/a"));

        
        /// Games containers
        public IWebElement BookOfRaImage => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[4]/div[2]/div[3]/div[1]"));
        public IWebElement BookOfRaPlay => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[4]/div[2]/div[3]/div[1]/div/span[1]"));
        public IWebElement BookOfRaPlay777 => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[3]/div/div/div[4]/div/div[1]/div/div/a[1]"));

        // Quickspin
        //public IWebElement StickyBanditsContinueButton => Driver.WaitUntilVisible(By.Id("ContinueButton"));   
        public IWebElement StickyBanditsContinueButton => Driver.WaitUntilVisible(By.XPath("//*[@id='continuebutton_symbol']"));
        public IWebElement StickyBanditsGameContainer => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[3]/div"));
        public IWebElement StickyBanditsSpin => Driver.WaitUntilVisible(By.Id("DefaultSpinButton"));


        //Ezugi
        
        public void MoveCursorToGame(IWebElement game)
        {
            Actions actions = new Actions(Driver.Browser);
            actions.MoveToElement(game).Click().Perform();
        }

        public void ButtonClick(IWebElement container, int coordx, int coordy)
        {
            Actions actions = new Actions(Driver.Browser);
            actions.MoveToElement(container, coordx, coordy).Click().Perform();
        }

        public void FullscrinButtonClick()
        {
            Actions actions = new Actions(Driver.Browser);
            actions.MoveToElement(GameContainer, 1170, 30).Click().Perform();
        }

        public void LongKeyDown(IWebElement container, int coordx, int coordy)
        {
            Actions actions = new Actions(Driver.Browser);
            actions.MoveToElement(container, coordx, coordy).Perform();
            actions.ClickAndHold().Perform();
            System.Threading.Thread.Sleep(1000);
            actions.Release().Perform();
        }

        public void SpaceClick()
        {
            Actions actions = new Actions(Driver.Browser);
            actions.SendKeys(PartnersGameContainer, Keys.Space).Perform();
        }

        public void ReturnFocus()
        {
            Driver.Browser.Manage().Window.Size = new System.Drawing.Size(0, 0);
            Driver.Browser.Manage().Window.Maximize();
        }
        public IWebElement Bakkaraplay => Driver.WaitUntilVisible(By.XPath("//*[@id='table_101']"));

        public System.Drawing.Size CalcContainerSize() => GameContainer.Size;
    }
}
