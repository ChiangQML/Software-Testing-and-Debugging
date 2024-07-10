using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using ClockAppTests.Pages;

namespace ClockAppTests
{
    [TestClass]
    public class AlarmTest
    {
        private WindowsDriver<WindowsElement> session;
        private AlarmPage alarmPage;

        [TestInitialize]
        public void Setup()
        {
            var appiumOptions = new AppiumOptions();
            appiumOptions.AddAdditionalCapability("app", "Microsoft.WindowsAlarms_8wekyb3d8bbwe!App");
            appiumOptions.AddAdditionalCapability("deviceName", "WindowsPC");
            session = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), appiumOptions);
            alarmPage = new AlarmPage(session);
        }

        [TestMethod]
        public void Test_SetStopWatchFor5sec()
        {
            alarmPage.run();
            Thread.Sleep(5000);
            alarmPage.lap();
            alarmPage.reset();
            Thread.Sleep(2000);
        }

        [TestCleanup]
        public void TearDown()
        {
            session?.Quit();
        }
    }
}
