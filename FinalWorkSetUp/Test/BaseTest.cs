using FinalWorkAsos.Drivers;
using FinalWorkAsos.Page;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;

namespace FinalWorkAsos.Test
{
    public class BaseTest
    {
        public static IWebDriver driver;
        public static AsosPage _asosPage;


        [OneTimeSetUp]
        public static void SetUp()
        {
            driver = CustomDriver.GetChromeDriver();
            _asosPage = new AsosPage(driver);
        }

        [TearDown]
        public static void TakeScreeshot()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
                MyScreenshot.MakeScreeshot(driver);
        }

        [OneTimeTearDown]
        public static void TearDown()
        {
            //    driver.Quit();
        }
    }
}
