using OpenQA.Selenium;

namespace SlotokingUIAuto
{
    public class KingMainPage
    {
        public KingMainPage() {}

        public IWebElement DownloadDesktopButton => Driver.WaitUntilVisible(By.ClassName("down-install-inst"));

        public IWebElement SendSmsButton => Driver.WaitUntilVisible(By.ClassName("btn-blue sendAndroidLink"));

        public IWebElement LoginButton => Driver.WaitUntilVisible(By.Id("enterButtonTop"));

        public IWebElement RegistrationButton => Driver.WaitUntilVisible(By.ClassName("btn btn-green"));

        public IWebElement PhoneTextBox => Driver.WaitUntilVisible(By.Id("PhoneForm_phone"));

        public IWebElement WelcomeText => Driver.WaitUntilVisible(By.ClassName("seo_h1"));
    }
}
    


