using OpenQA.Selenium;

namespace SlotokingUIAuto
{
    public class HeaderButtons 
    {
        public IWebElement LoginButton => Driver.WaitUntilVisible(By.Id("enterButtonTop"));
        public IWebElement RegistrationButton => Driver.WaitUntilVisible(By.Id("registrationButtonTop"));
        public IWebElement TournamentsLnk => Driver.WaitUntilVisible(By.LinkText("Турниры"));
        public IWebElement BonusesLnk => Driver.WaitUntilVisible(By.LinkText("Бонусы"));
        public IWebElement GamesLnk => Driver.WaitUntilVisible(By.LinkText("Игры"));             
        public IWebElement VIPLnk => Driver.WaitUntilVisible(By.LinkText("VIP"));
        public IWebElement PaymentsLnk => Driver.WaitUntilVisible(By.LinkText("Методы оплаты"));          
        public IWebElement ProfileLink => Driver.WaitUntilVisible(By.LinkText("Профиль"));
        public IWebElement IncrCash => Driver.WaitUntilVisible(By.PartialLinkText("Пополнить"));       
        public IWebElement BalanceText => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[2]/div/div[2]/div[2]/span[1]/text()"));
    }
}
