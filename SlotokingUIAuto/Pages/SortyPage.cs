using OpenQA.Selenium;

namespace SlotokingUIAuto
{
    public class SortyPage
    {
        public SortyPage() {}

        public IWebElement TitleText => Driver.WaitUntilVisible(By.ClassName("title"));
        public IWebElement WelcomeScreenHeaderText => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[1]/div/div[2]/div[1]/div[1]"));       
    }
}