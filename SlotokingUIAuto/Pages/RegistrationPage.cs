using OpenQA.Selenium;
using System;

namespace SlotokingUIAuto
{
    public class RegWizardPage
    {
        // 1 Page
        // Bonusess Block
        public IWebElement RegistrationFirstBonus => Driver.WaitUntilVisible(By.Id("//*[@id='vuePopup']/div[1]/div[1]/div/div[2]/div[1]/div[2]/div[1]/div"));
        public IWebElement RegistrationSecondBonus => Driver.WaitUntilVisible(By.Id("//*[@id='vuePopup']/div[1]/div[1]/div/div[2]/div[1]/div[2]/div[2]/div"));

        // Email Block
        public IWebElement RegistrationEmailTab => Driver.WaitUntilVisible(By.XPath("//*[@id='vuePopup']/div[1]/div[1]/div/div[2]/div[2]/div/div[2]/div/a[1]/span"));
        public IWebElement RegistrationEmailTextBox => Driver.WaitUntilVisible(By.Id("emailReg"));
        public IWebElement RegistrationPasswordTextBox => Driver.WaitUntilVisible(By.Id("passwordReg"));
        public IWebElement RegistrationViePasswordButton => Driver.WaitUntilVisible(By.XPath("//*[@id='vuePopup']/div[1]/div[1]/div/div[2]/div[2]/div/div[2]/form/div[2]/div[1]/span[1]"));

        // Phone Block
        public IWebElement RegistrationPhoneTab => Driver.WaitUntilVisible(By.XPath("//*[@id='vuePopup']/div[1]/div[1]/div/div[2]/div[2]/div/div[2]/div/a[2]/span"));
        public IWebElement RegistrationSelectedFlag => Driver.WaitUntilVisible(By.XPath("//*[@id='reg-type-panel']/div/div/div[1]/div"));
        public IWebElement RegistrationSelectedUaFlag => Driver.WaitUntilVisible(By.XPath("//*[@id='reg-type-panel']/div/div/div[1]/div/div[1]"));
        public IWebElement RegistrationPhoneTextBox => Driver.WaitUntilVisible(By.Id("inputPhoneRegister"));

        // Currency Block
        public IWebElement RegistrationRadioButtonUa => Driver.WaitUntilVisible(By.XPath("//*[@id='vuePopup']/div[1]/div[1]/div/div[2]/div[2]/div/div[2]/form/div[2]/div[2]/label[1]/span[4]"));
        public IWebElement RegistrationRadioButtonRub => Driver.WaitUntilVisible(By.XPath("//*[@id='vuePopup']/div[1]/div[1]/div/div[2]/div[2]/div/div[2]/form/div[2]/div[2]/label[2]/span[4]"));
        public IWebElement RegistrationRadioButtonUsd => Driver.WaitUntilVisible(By.XPath("//*[@id='vuePopup']/div[1]/div[1]/div/div[2]/div[2]/div/div[2]/form/div[2]/div[2]/label[3]/span[4]"));

        // 2 Page (50 free-spin no deposit)
        // First, Last Name Block
        public IWebElement RegistrationFirstNameTextBox => Driver.WaitUntilVisible(By.Id("playerFirstName"));
        public IWebElement RegistrationLastNameTextBox => Driver.WaitUntilVisible(By.Id("playerLastName"));

        // Date Birthday Block
        public IWebElement RegistrationPlayerBirthDay => Driver.WaitUntilVisible(By.Id("playerBirthDay"));
        public IWebElement RegistrationPlayerBirthSecondDay => Driver.WaitUntilVisible(By.XPath("//*[@id='playerBirthDay']/option[2]"));
        public IWebElement RegistrationPlayerBirthMounth => Driver.WaitUntilVisible(By.Id("playerBirthMonth"));
        public IWebElement RegistrationPlayerBirtFebruaryhMounth => Driver.WaitUntilVisible(By.XPath("//*[@id='playerBirthMonth']/option[2]"));
        public IWebElement RegistrationPlayerBirthYear => Driver.WaitUntilVisible(By.Id("playerBirthYear"));
        public IWebElement RegistrationPlayerBirth2003Year => Driver.WaitUntilVisible(By.XPath("//*[@id='playerBirthYear']/option[2]"));

        // 3 Page (50 free-spin no deposit)
        // Adress Block
        public IWebElement RegistrationSelectCountry => Driver.WaitUntilVisible(By.Id("playerCountry"));
        public IWebElement RegistrationSelectCountryUa => Driver.WaitUntilVisible(By.XPath("//*[@id='playerCountry']/option[1]"));
        public IWebElement RegistrationCityTextBox => Driver.WaitUntilVisible(By.Id("playerCity"));
        public IWebElement RegistrationAdressTextBox => Driver.WaitUntilVisible(By.Id("playerAddress"));

        // 4 Page
        public IWebElement RegistrationEmailTextField => Driver.WaitUntilVisible(By.Id("playerEmail"));
        public IWebElement RegistrationConfirmButton => Driver.WaitUntilVisible(By.XPath("//*[@id='vuePopup']/div[2]/div/div[2]/div[2]/div/div[2]/form/div[1]/div[2]/a"));
        public IWebElement RegistrationConfirmEmailTextBox => Driver.WaitUntilVisible(By.Id("playerConfirmEmail"));

        // Button Block
        public IWebElement RegistrationNextButton => Driver.WaitUntilVisible(By.XPath("//*[@id='vuePopup']/div[2]/div/div[2]/div[2]/div/div[2]/form/div[2]/button/span[2]"));
        public IWebElement RegistrationCloseButton => Driver.WaitUntilVisible(By.XPath("//*[@id='vuePopup']/div[1]/div[1]/div/div[2]/span"));      
    }
}

