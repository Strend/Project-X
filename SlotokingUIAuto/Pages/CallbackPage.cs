using OpenQA.Selenium;

namespace SlotokingUIAuto
{
    public class CallbackPage
    {
        public IWebElement ErrorText => Driver.WaitUntilVisible(By.XPath("/html/body/h2"));
    }
}
