﻿using OpenQA.Selenium;


namespace SlotokingUIAuto.Pages
{
    public class Cashbox
    {
       
        public IWebElement CashboxButton => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[2]/div/div[2]/div[3]/a/span"));
        public IWebElement CashboxPopupTakeMethodVisa => Driver.WaitUntilVisible(By.XPath("//*[@id='payments-in-form']/div[1]/span[2]/label/div/i"));
        public IWebElement CashboxPopupTakeMethodVisaMaster => Driver.WaitUntilVisible(By.XPath("//*[@id='payments-in-form']/div[1]/span[1]/label/div/i"));
        public IWebElement CashboxPopupAgreeVisaMaster => Driver.WaitUntilVisible(By.XPath("/html/body/div[1]/div[1]/div[2]/div[2]/span/span[2]"));
        public IWebElement CashboxPopupTakeMethodWebmoney => Driver.WaitUntilVisible(By.XPath("//*[@id='payments-in-form']/div[1]/span[3]"));
        public IWebElement CashboxPopupAgreeWebmoney => Driver.WaitUntilVisible(By.XPath("//*[@id='signedloginform']/div[1]/div/label"));
        public IWebElement CashboxPopupTakeMethodPrivat24 => Driver.WaitUntilVisible(By.XPath("//*[@id='payments-in-form']/div[1]/span[4]"));
        public IWebElement CashboxPopupAgreePrivat24 => Driver.WaitUntilVisible(By.XPath("//*[@id='app']/div/div/div[2]/div[2]/div[1]/div[1]"));
        public IWebElement CashboxPopupInputQiwi => Driver.WaitUntilVisible(By.XPath("//*[@id='desktop_modules_cash_models_PaymentFormIn_add_fields_phone']"));
        public IWebElement CashboxPopupTakeMethodQiwi => Driver.WaitUntilVisible(By.XPath("//*[@id='payments-in-form']/div[1]/span[5]"));
        public IWebElement CashboxPopupAgreeQiwi => Driver.WaitUntilVisible(By.XPath("//*[@id='root']/div/div[1]/div[1]/div[2]/div[1]/div[2]/span[1]"));

        public IWebElement CashboxPopupTakeMethodYandex => Driver.WaitUntilVisible(By.XPath("//*[@id='payments-in-form']/div[1]/span[6]"));
        public IWebElement CashboxPopupAgreeYandex => Driver.WaitUntilVisible(By.XPath("/html/body/div[2]/div[2]/div[1]/div[1]/div[1]/div/div/h1"));
        public IWebElement CashboxPopupOpenAnother => Driver.WaitUntilVisible(By.XPath("//*[@id='payments-in-form']/div[1]/span[7]"));
        public IWebElement CashboxPopupOpenWalletone => Driver.WaitUntilVisible(By.XPath("//*[@id='payments-in-form']/div[2]/div/span[1]"));
        public IWebElement CashboxPopupAgreeWalletone => Driver.WaitUntilVisible(By.XPath("/html/body/div[2]/div[2]/div/div[1]/div[2]/div[1]/div[1]/div[5]/div[2]"));
        public IWebElement CashboxPopupOpenSberBank => Driver.WaitUntilVisible(By.XPath("//*[@id='payments-in-form']/div[2]/div/span[2]"));
        public IWebElement CashboxPopupAgreeSberBank => Driver.WaitUntilVisible(By.XPath("/html/body/div[4]/div[1]/div[4]/div[1]/div[1]/h2"));
        public IWebElement CashboxPopupOpenPsb => Driver.WaitUntilVisible(By.XPath("//*[@id='payments-in-form']/div[2]/div/span[4]"));
        public IWebElement CashboxPopupAgreePsb => Driver.WaitUntilVisible(By.XPath("/html/body/div[2]/div[1]/div[1]/div/div/div[2]/span[2]"));
        public IWebElement CashboxPopupOpenAlfaBank => Driver.WaitUntilVisible(By.XPath("//*[@id='payments-in-form']/div[2]/div/span[3]"));
        public IWebElement CashboxPopupAgreeAlfaBank => Driver.WaitUntilVisible(By.XPath("/html/body/div[2]/div[1]/div[1]/div/div/div[2]/span[2]"));
        public IWebElement CashboxPopupOpenPerfectMoney => Driver.WaitUntilVisible(By.XPath("//*[@id='payments-in-form']/div[2]/div/span[5]"));
        public IWebElement CashboxPopupAgreePerfectMoney => Driver.WaitUntilVisible(By.XPath("//*[@id='auth']/table[2]/tbody/tr/td[2]/table/tbody/tr[1]/td/table[2]/tbody/tr/td/table/tbody/tr/td/div/form/table[1]/tbody/tr/td[1]/h1/font"));

        public IWebElement CashboxPopupOpenAdvancedCash => Driver.WaitUntilVisible(By.XPath("//*[@id='payments-in-form']/div[2]/div/span[6]"));
        public IWebElement CashboxPopupAgreeAdvancedCash => Driver.WaitUntilVisible(By.XPath("/html/body/div[2]/div/div/div[2]/div/div/h1"));

        public IWebElement CashboxPopupOpenPayeer => Driver.WaitUntilVisible(By.XPath("//*[@id='payments-in-form']/div[2]/div/span[7]"));
        public IWebElement CashboxPopupAgreePayeer => Driver.WaitUntilVisible(By.XPath("/html/body/div[3]/div/div[2]"));
















        



        public IWebElement CashboxPopupInput => Driver.WaitUntilVisible(By.XPath("//*[@id='anothe-amount']"));
        public IWebElement CashboxPopuptakeBonus => Driver.WaitUntilVisible(By.XPath("//*[@id='desktop_modules_cash_models_PaymentFormIn_bonus_id-styler']/div[1]/div[1]"));

        public IWebElement CashboxPopuptakeBonusSelect => Driver.WaitUntilVisible(By.XPath("//*[@id='desktop_modules_cash_models_PaymentFormIn_bonus_id-styler']/div[2]/ul/li[2]"));
        public IWebElement CashboxPopupButtonpush => Driver.WaitUntilVisible(By.XPath("//*[@id='payments-in-form']/div[4]/div[2]/div/div[4]/button"));
        public IWebElement CashboxPopupnextSteppush => Driver.WaitUntilVisible(By.XPath("//*[@id='popup-next-step']/div/div/div[2]/a"));

        public IWebElement Cashbox200ua => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[2]/div/div[2]/div[2]/span[1]/text()"));
        public IWebElement Paymentspage => Driver.WaitUntilVisible(By.XPath("/html/body/div[2]/div/div[1]/div/div[2]/div/div/div[3]/div[1]/div[2]/div[1]/div[2]/span[1]"));
        public IWebElement CashboxPopup => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[2]/div/div[2]/div[2]/span[1]/text()"));

        public IWebElement CashboxPopupWithdrawButton => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div/div[2]/div[1]/ul/li[2]/a"));

        public IWebElement CashboxPopupSelectW => Driver.WaitUntilVisible(By.XPath("//*[@id='desktop_modules_cash_models_PaymentFormOut_output_id-styler']/div[1]/div[1]"));

        public IWebElement CashboxPopupInputSumma => Driver.WaitUntilVisible(By.XPath("//*[@id='desktop_modules_cash_models_PaymentFormOut_amount']"));

        public IWebElement CashboxPopupSelectWMaster => Driver.WaitUntilVisible(By.XPath("//*[@id='desktop_modules_cash_models_PaymentFormOut_output_id-styler']/div[2]/ul/li[6]"));

        public IWebElement CashboxPopuprequisite => Driver.WaitUntilVisible(By.XPath("//*[@id='desktop_modules_cash_models_PaymentFormOut_requisite']"));
        public IWebElement CashboxPopupWButton => Driver.WaitUntilVisible(By.XPath("//*[@id='payments-out-form']/div[6]/button"));

        public IWebElement CashboxPopupSucespay => Driver.WaitUntilVisible(By.XPath("//*[@id='popup-out-success']/div/div/div[2]"));
        public IWebElement CashboxPopupCPButton => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div/div[2]/div[1]/ul/li[3]/a"));
        public IWebElement CashboxPopupCPinput => Driver.WaitUntilVisible(By.XPath("//*[@id='desktop_modules_cash_models_PaymentFormExchange_amount_cp']"));
        public IWebElement CashboxPopupCPButtonOK => Driver.WaitUntilVisible(By.XPath("//*[@id='payments-exchange-form']/div[3]/button"));
        public IWebElement CashboxPopupCPchangeOK => Driver.WaitUntilVisible(By.XPath("//*[@id='popup-exchange-success']/div/div/div[3]/a"));
        public IWebElement CashboxPopupCPchangeSuccess => Driver.WaitUntilVisible(By.XPath("//*[@id='desktop_modules_cash_models_PaymentFormExchange_amount_cp_em_']"));
        public IWebElement CashboxPopupCPchangeSuccessClose => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[2]/div/div[2]/div[2]/span[1]/text()"));
        public IWebElement CashboxPopupWBonusinFirstdepositMainpage => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div[2]/div/div[2]/div[2]/span[1]/text()"));
        public IWebElement ClosePopupVivod => Driver.WaitUntilVisible(By.XPath("//*[@id='popup-out-success']/div/div/div[3]/a"));
               
        public IWebElement HistoryFrame => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div/div[2]/div[1]/ul/li[4]/a"));
        public IWebElement СancelWithdrawal => Driver.WaitUntilVisible(By.XPath("//*[@id='wrapper']/div/div[2]/div[2]/div[2]/div/div/div[2]/table/tbody/tr[2]/td[7]/a"));
        public IWebElement ConfirmationOfCancellationOfOutput => Driver.WaitUntilVisible(By.XPath("//*[@id='popup-cancel']/div/div/div[2]/a[1]"));
        public IWebElement OtmenaSdelana => Driver.WaitUntilVisible(By.XPath("//*[@id='popup-success']/div/div/div[1]"));


        






        public void EnterCashbox()
        {
            CashboxButton.Click();
            //CashboxPopup.Click();
            Driver.Browser.SwitchTo().Frame("frame-cash");
            
        }


    }
}