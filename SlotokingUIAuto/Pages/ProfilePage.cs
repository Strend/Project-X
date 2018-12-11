using OpenQA.Selenium;

namespace SlotokingUIAuto
{
    public class ProfilePage
    {
        public IWebElement DashboardTab => Driver.WaitUntilVisible(By.ClassName("active"));

        public IWebElement DepositForm => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[3]/div/div/ul/li[2]/a"));

        public IWebElement AccountTab => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[3]/div/div/ul/li[3]/a"));

        public IWebElement BonusesPersonalTab => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[3]/div/div/ul/li[4]/a"));

        public IWebElement ProfileHeaderText => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[3]/div/div/div"));

        public IWebElement SuccessSaveMessage => Driver.WaitUntilVisible(By.XPath("//*[@id='profile-form']/div/div/div[2]"));

        public void Logout(IWebDriver webdriver)
        {
            webdriver.Url = TestDataResource.MainPageURL + "/profile/dashboard/";          
            IWebElement logout = webdriver.FindElement(By.XPath("//*[@id='wrapper']/div[3]/div/div/ul/li[5]/a"));
            logout.Click();
        }            
    }
}
