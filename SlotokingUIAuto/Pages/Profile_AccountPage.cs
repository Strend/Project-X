using OpenQA.Selenium;

namespace SlotokingUIAuto
{
    class Profile_AccountPage : ProfilePage 
    {
        public IWebElement NameTextBox => Driver.WaitUntilVisible(By.XPath("//*[@id='Players_name']"));

        public IWebElement SurnameTextBox => Driver.WaitUntilVisible(By.XPath("//*[@id='Players_surname']"));

        public IWebElement NicknameTextBox => Driver.WaitUntilVisible(By.XPath("//*[@id='Players_nickname']"));

        public IWebElement MaleGenderRadioButton => Driver.WaitUntilVisible(By.XPath("//*[@id='Players_gender_id_0-styler']"));

        public IWebElement DaySelectBox => Driver.WaitUntilVisible(By.XPath("//*[@id='Players_birth_day-styler']/div[1]"));

        public IWebElement MonthSelectBox => Driver.WaitUntilVisible(By.XPath("//*[@id='Players_birth_month-styler']/div[1]/div[1]"));

        public IWebElement YearSelectBox => Driver.WaitUntilVisible(By.XPath("//*[@id='Players_birth_year-styler']/div[1]/div[1]"));

        public IWebElement SaveTitleButton => Driver.WaitUntilVisible(By.XPath("//*[@id='profile-form']/div/div/div[3]/div[1]/div/button"));

        public IWebElement SavePhoneButton => Driver.WaitUntilVisible(By.XPath("//*[@id='profile-form']/div/div/div[5]/div[1]/div/div[3]/div[2]/button"));

        public IWebElement SavePersonalInfoButton => Driver.WaitUntilVisible(By.XPath("//*[@id='profile-form']/div/div/div[3]/div[2]/div/button"));

        public IWebElement PlayerPhoneTextBox => Driver.WaitUntilVisible(By.Id("Players_phone"));

        public IWebElement CountryListBox => Driver.WaitUntilVisible(By.XPath("//*[@id='Players_country_id-styler']/div[1]"));

        public IWebElement UkraineyListBoxElement => Driver.WaitUntilVisible(By.XPath(" //*[@id='Players_country_id-styler']/div[2]/ul/li[6]"));

        public IWebElement CityTextBox => Driver.WaitUntilVisible(By.Id("Players_city"));

        public IWebElement AddressListBox => Driver.WaitUntilVisible(By.Id("Players_address"));

        public void FillDate()
        {
            DaySelectBox.Click();
            Driver.WaitUntilVisible(By.XPath("//*[@id='Players_birth_day-styler']/div[2]/ul/li[3]")).Click();
            
            MonthSelectBox.Click();
            Driver.WaitUntilVisible(By.XPath("//*[@id='Players_birth_month-styler']/div[2]/ul/li[5]")).Click();
           
            YearSelectBox.Click();
            Driver.WaitUntilVisible(By.XPath("//*[@id='Players_birth_year-styler']/div[2]/ul/li[4]")).Click();            
        }

        public void ChooseCountry()
        {
            CountryListBox.Click();
            UkraineyListBoxElement.Click();
        }


    }
}
