using OpenQA.Selenium.Appium.Windows;

namespace ClockAppTests.Pages
{
    public class AlarmPage
    {
        private WindowsDriver<WindowsElement> driver;

        public AlarmPage(WindowsDriver<WindowsElement> driver)
        {
            this.driver = driver;
        }

        public WindowsElement StopwatchPlayPauseButton => driver.FindElementByAccessibilityId("StopwatchPlayPauseButton");
        public WindowsElement StopWatchLapButton => driver.FindElementByAccessibilityId("StopWatchLapButton");
        public WindowsElement StopWatchResetButton => driver.FindElementByAccessibilityId("StopWatchResetButton");

        public void run()
        {
            StopwatchPlayPauseButton.Click();
        }

        public void lap() 
        {
            StopWatchLapButton.Click();
        }

        public void reset()
        {
            StopWatchResetButton.Click();
        }
    }
}
