using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium.Remote;

namespace SlotokingUIAuto
{
    public static class Driver
    {
        public static IWebDriver Browser { get; private set; }
        public static WebDriverWait BrowserWait { get; private set; }

        public static IWebElement WaitUntilVisible(By locator) => BrowserWait.Until(ExpectedConditions.ElementIsVisible(locator));
        public static IWebElement WaitUntilClickable(By locator) => BrowserWait.Until(ExpectedConditions.ElementToBeClickable(locator));

        public static void StartBrowser(Platforms platform = Platforms.Desktop, BrowserTypes browserType = BrowserTypes.Chrome, int defaultTimeOut = 30)
        {
            switch (platform)
            {
                case (Platforms.Desktop):
                    switch (browserType)
                    {
                        case BrowserTypes.Firefox:
                            Browser = new FirefoxDriver();
                            break;
                        case BrowserTypes.InternetExplorer:
                            Browser = new InternetExplorerDriver();
                            break;
                        case BrowserTypes.Chrome:
                            ChromeOptions options = new ChromeOptions();
                            options.AddUserProfilePreference("profile.default_content_setting_values.plugins", 1);
                            options.AddUserProfilePreference("profile.content_settings.plugin_whitelist.adobe-flash-player", 1);
                            options.AddUserProfilePreference("profile.content_settings.exceptions.plugins.*,*.per_resource.adobe-flash-player", 1);
                            options.AddUserProfilePreference("PluginsAllowedForUrls", "http:/ ");
                            options.AddUserProfilePreference("PluginsAllowedForUrls", "https://slotoking.com");
                            Browser = new ChromeDriver(options);
                            break;
                        case BrowserTypes.Edge:
                            Browser = new EdgeDriver();
                            break;
                        default:
                            Browser = new ChromeDriver();
                            break;
                    }
                    BrowserWait = new WebDriverWait(Driver.Browser, TimeSpan.FromSeconds(defaultTimeOut));
                    break;
            }
        }

        public static void StartDeviceAndroid(Platforms platform = Platforms.Android, BrowserTypes browserTypes = BrowserTypes.Chrome, int defaultTimeOut = 30)
        {


            var options = new ChromeOptions();
            options.PlatformName = "Android";
            options.AddAdditionalCapability("deviceName", "Samsung s7");
            options.AddAdditionalCapability("platformVersion", "8.0");
            options.AddAdditionalCapability("newCommandTimeout", 600);
            options.AddAdditionalCapability("idleTimeout", 900);
            var driver = new RemoteWebDriver(new Uri("http://127.0.0.1:4723/wd/hub"), options.ToCapabilities());



        }

        public static void TakeScreenshot(string screenName)
        {
            try
            {
                Thread.Sleep(1500);
                string screensLocation = @"E:\TestScreen\";
                string testName = TestContext.CurrentContext.Test.Name;
                var screenshot = ((ITakesScreenshot)Driver.Browser).GetScreenshot();
                screenshot.SaveAsFile(screensLocation + testName + "_" + DateTime.Now.ToString("dd_MMMM_hh_mm_ss_tt") + ".png");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        public static void DisposeBrowser()
        {
            if (Browser != null)
            {
                Browser.Quit();
                Browser = null;
                BrowserWait = null;
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
