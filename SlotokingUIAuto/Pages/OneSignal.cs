using OpenQA.Selenium;

namespace SlotokingUIAuto
{
    class OneSignal
    {       
        public IWebElement OkButton => Driver.WaitUntilVisible(By.Id("onesignal-popover-allow-button"));        
        public IWebElement CancelButton => Driver.WaitUntilVisible(By.Id("onesignal-popover-cancel-button"));      
    }
}
