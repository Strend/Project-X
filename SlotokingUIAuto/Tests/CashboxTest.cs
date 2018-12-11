using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using SlotokingUIAuto.Pages;
using System;

namespace SlotokingUIAuto
{
    class CashboxTest
    {
        string login = "djust_test@mail.ru";


        [SetUp]
        public void BeforeTest()
        {
            Driver.StartBrowser();
            Driver.Browser.Manage().Window.Maximize();
        }


        [Test]


        public void CashierReplenishment()
        {
            VuePopup vue = new VuePopup();
            vue.Auth(login, false);
            Cashbox replish = new Cashbox();
            replish.EnterCashbox();
            replish.CashboxPopupTakeMethodVisa.Click();
            replish.CashboxPopupInput.SendKeys(TestDataResource.Payments);
            replish.CashboxPopupButtonpush.Click();
            replish.CashboxPopupnextSteppush.Click();

            Driver.Browser.SwitchTo().Window(Driver.Browser.WindowHandles[1]);
            StringAssert.AreEqualIgnoringCase("999", replish.Paymentspage.Text);

        }

        [Test]
        [Ignore("фрейм во фрейме")]
        public void CashierReplenishmentVisaMaster()
        {
            VuePopup vue = new VuePopup();
            vue.Auth(login, false);
            Cashbox replish = new Cashbox();
            //WelcomePage welcome = new WelcomePage();
            //welcome.CancelButton.Click();
            replish.EnterCashbox();
            replish.CashboxPopupTakeMethodVisaMaster.Click();
            replish.CashboxPopupInput.SendKeys(TestDataResource.Payments);
            replish.CashboxPopupButtonpush.Click();

            Driver.Browser.SwitchTo().Frame("frame-cash");
            System.Threading.Thread.Sleep(5000);
            Driver.Browser.SwitchTo().Frame("frame-cash-inner");
            System.Threading.Thread.Sleep(5000);
            StringAssert.AreEqualIgnoringCase("999.00", replish.CashboxPopupAgreeVisaMaster.Text);

        }



        [Test]
        public void CashierReplenishmentWebmoney()
        {
            VuePopup vue = new VuePopup();
            vue.Auth(login, false);
            Cashbox replish = new Cashbox();
            replish.EnterCashbox();
            replish.CashboxPopupTakeMethodWebmoney.Click();
            replish.CashboxPopupInput.SendKeys(TestDataResource.Payments);
            replish.CashboxPopupButtonpush.Click();
            replish.CashboxPopupnextSteppush.Click();

            Driver.Browser.SwitchTo().Window(Driver.Browser.WindowHandles[1]);
            StringAssert.AreEqualIgnoringCase("Выберите способ оплаты", replish.CashboxPopupAgreeWebmoney.Text);

        }

        [Test]
        public void CashierReplenishmentPrivat24()
        {
            VuePopup vue = new VuePopup();
            vue.Auth(login, false);
            Cashbox replish = new Cashbox();
            replish.EnterCashbox();
            replish.CashboxPopupTakeMethodPrivat24.Click();
            replish.CashboxPopupInput.SendKeys(TestDataResource.Payments);
            replish.CashboxPopupButtonpush.Click();
            replish.CashboxPopupnextSteppush.Click();

            Driver.Browser.SwitchTo().Window(Driver.Browser.WindowHandles[1]);
            StringAssert.AreEqualIgnoringCase("USD:", replish.CashboxPopupAgreePrivat24.Text);

        }


        [Test]
        public void CashierReplenishmentQiwi()
        {
            VuePopup vue = new VuePopup();
            vue.Auth(login, false);
            Cashbox replish = new Cashbox();
            replish.EnterCashbox();
            replish.CashboxPopupTakeMethodQiwi.Click();
            replish.CashboxPopupInput.SendKeys(TestDataResource.Payments);
            replish.CashboxPopupInputQiwi.SendKeys(TestDataResource.QiwiPhone);
            replish.CashboxPopupButtonpush.Click();
            replish.CashboxPopupnextSteppush.Click();

            Driver.Browser.SwitchTo().Window(Driver.Browser.WindowHandles[1]);
            StringAssert.AreEqualIgnoringCase("QIWI", replish.CashboxPopupAgreeQiwi.Text);

        }

        [Test]
        public void CashierReplenishmentYandex()
        {
            VuePopup vue = new VuePopup();
            vue.Auth(login, false);
            Cashbox replish = new Cashbox();
            replish.EnterCashbox();
            replish.CashboxPopupTakeMethodYandex.Click();
            replish.CashboxPopupInput.SendKeys(TestDataResource.Payments);
            replish.CashboxPopupButtonpush.Click();
            replish.CashboxPopupnextSteppush.Click();

            Driver.Browser.SwitchTo().Window(Driver.Browser.WindowHandles[1]);
            StringAssert.AreEqualIgnoringCase("slotoking.com", replish.CashboxPopupAgreeYandex.Text);

        }


        [Test]
        public void CashierReplenishmentWalletOne()
        {
            VuePopup vue = new VuePopup();
            vue.Auth(login, false);
            Cashbox replish = new Cashbox();
            replish.EnterCashbox();
            replish.CashboxPopupOpenAnother.Click();
            replish.CashboxPopupOpenWalletone.Click();
            replish.CashboxPopupInput.SendKeys(TestDataResource.Payments);
            replish.CashboxPopupButtonpush.Click();
            replish.CashboxPopupnextSteppush.Click();

            Driver.Browser.SwitchTo().Window(Driver.Browser.WindowHandles[1]);
            StringAssert.AreEqualIgnoringCase("999.00 ₴", replish.CashboxPopupAgreeWalletone.Text);

        }

        [Test]
        public void CashierReplenishmentSberBank()
        {
            VuePopup vue = new VuePopup();
            vue.Auth(login, false);
            Cashbox replish = new Cashbox();
            replish.EnterCashbox();
            replish.CashboxPopupOpenAnother.Click();
            replish.CashboxPopupOpenSberBank.Click();
            replish.CashboxPopupInput.SendKeys(TestDataResource.Payments);
            replish.CashboxPopupButtonpush.Click();
            replish.CashboxPopupnextSteppush.Click();

            Driver.Browser.SwitchTo().Window(Driver.Browser.WindowHandles[1]);
            StringAssert.AreEqualIgnoringCase("Сбербанк ОнЛ@йн", replish.CashboxPopupAgreeSberBank.Text);

        }


        [Test]
        public void CashierReplenishmentPsb()
        {
            VuePopup vue = new VuePopup();
            vue.Auth(login, false);
            Cashbox replish = new Cashbox();
            replish.EnterCashbox();
            replish.CashboxPopupOpenAnother.Click();
            replish.CashboxPopupOpenPsb.Click();
            replish.CashboxPopupInput.SendKeys(TestDataResource.Payments);
            replish.CashboxPopupButtonpush.Click();
            replish.CashboxPopupnextSteppush.Click();

            Driver.Browser.SwitchTo().Window(Driver.Browser.WindowHandles[1]);
            StringAssert.AreEqualIgnoringCase("DEPOSIT", replish.CashboxPopupAgreePsb.Text);

        }

        [Test]
        public void CashierReplenishmentPerfectMoney()
        {
            VuePopup vue = new VuePopup();
            vue.Auth(login, false);
            Cashbox replish = new Cashbox();
            replish.EnterCashbox();
            replish.CashboxPopupOpenAnother.Click();
            replish.CashboxPopupOpenPerfectMoney.Click();
            replish.CashboxPopupInput.SendKeys(TestDataResource.Payments);
            replish.CashboxPopupButtonpush.Click();
            replish.CashboxPopupnextSteppush.Click();

            Driver.Browser.SwitchTo().Window(Driver.Browser.WindowHandles[1]);
            StringAssert.AreEqualIgnoringCase("Perfect Money®", replish.CashboxPopupAgreePerfectMoney.Text);

        }

        [Test]
        public void CashierReplenishmentAlfaBank()
        {
            VuePopup vue = new VuePopup();
            vue.Auth(login, false);
            Cashbox replish = new Cashbox();
            replish.EnterCashbox();
            replish.CashboxPopupOpenAnother.Click();
            replish.CashboxPopupOpenAlfaBank.Click();
            replish.CashboxPopupInput.SendKeys(TestDataResource.Payments);
            replish.CashboxPopupButtonpush.Click();
            replish.CashboxPopupnextSteppush.Click();

            Driver.Browser.SwitchTo().Window(Driver.Browser.WindowHandles[1]);
            StringAssert.AreEqualIgnoringCase("DEPOSIT", replish.CashboxPopupAgreeAlfaBank.Text);

        }


        [Test]
        public void CashierReplenishmentAdvancedCash()
        {
            VuePopup vue = new VuePopup();
            vue.Auth(login, false);
            Cashbox replish = new Cashbox();
            replish.EnterCashbox();
            replish.CashboxPopupOpenAnother.Click();
            replish.CashboxPopupOpenAdvancedCash.Click();
            replish.CashboxPopupInput.SendKeys(TestDataResource.Payments);
            replish.CashboxPopupButtonpush.Click();
            replish.CashboxPopupnextSteppush.Click();

            Driver.Browser.SwitchTo().Window(Driver.Browser.WindowHandles[1]);
            StringAssert.AreEqualIgnoringCase("Вход в Advanced Cash для оплаты заказа", replish.CashboxPopupAgreeAdvancedCash.Text);

        }

        [Test]
        public void CashierReplenishmentPayeer()
        {
            VuePopup vue = new VuePopup();
            vue.Auth(login, false);
            Cashbox replish = new Cashbox();
            replish.EnterCashbox();
            replish.CashboxPopupOpenAnother.Click();
            replish.CashboxPopupOpenPayeer.Click();
            replish.CashboxPopupInput.SendKeys(TestDataResource.Payments);
            replish.CashboxPopupButtonpush.Click();
            replish.CashboxPopupnextSteppush.Click();

            Driver.Browser.SwitchTo().Window(Driver.Browser.WindowHandles[1]);
            StringAssert.AreEqualIgnoringCase("Авторизация", replish.CashboxPopupAgreePayeer.Text);

        }

                       

        [Test]

        public void CashWithdrawal()
        {
            VuePopup vue = new VuePopup();
            vue.Auth(login, false);
            Cashbox replish = new Cashbox();
            replish.EnterCashbox();

            replish.CashboxPopupWithdrawButton.Click();
            replish.CashboxPopupSelectW.Click();
            replish.CashboxPopupSelectWMaster.Click();

            replish.CashboxPopupInputSumma.SendKeys(TestDataResource.Payments);
            replish.CashboxPopuprequisite.Clear();

            replish.CashboxPopuprequisite.SendKeys(TestDataResource.CreditCardVisa);
            replish.CashboxPopupWButton.Click();
            StringAssert.AreEqualIgnoringCase("Заявка на выплату отправлена. Она будет обработана в течение 5-ти часов.", replish.CashboxPopupSucespay.Text);
            replish.ClosePopupVivod.Click();

        }

        [Test]
        public void СancelCashWithdrawal()
        {
            Cashbox replish = new Cashbox();
            CashWithdrawal();
            replish.HistoryFrame.Click();
            replish.СancelWithdrawal.Click();
            replish.ConfirmationOfCancellationOfOutput.Click();
            StringAssert.AreEqualIgnoringCase("Ваша заявка на вывод отменена", replish.OtmenaSdelana.Text);


        }

        [Test]

        public void CPChange()
        {
            VuePopup vue = new VuePopup();
            vue.Auth(login, false);
            Cashbox replish = new Cashbox();
            replish.EnterCashbox();

            replish.CashboxPopupCPButton.Click();
            replish.CashboxPopupCPinput.SendKeys("40");
            replish.CashboxPopupCPButtonOK.Click();
            StringAssert.AreEqualIgnoringCase("Недостаточно CP для обмена", replish.CashboxPopupCPchangeSuccess.Text);
            
        }




        [TearDown]
        public void AfterTest()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                Driver.TakeScreenshot("");

            }
            Driver.DisposeBrowser();
        }



        [OneTimeTearDown]
        public void AfterTestSuit() { }
    }
}
    