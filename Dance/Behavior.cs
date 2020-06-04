using OpenQA.Selenium.Chrome;
using System.Threading;

namespace JG.Dancing
{
    internal abstract class Behavior : Core
    {
        internal static void DanceRobot(ChromeDriver driver)
        {
            driver.ExecuteScript($"window.open('{ROBOT_DANCING_URL}', '_blank');");
            Thread.Sleep(WAIT_VIDEO_TIME);
        }
        internal static void SkipAdvertisement(ChromeDriver driver) => ActionButton(driver, "button.ytp-ad-skip-button.ytp-button", 6000);
        internal static void PlayVideo(ChromeDriver driver) => ActionButton(driver, "button.ytp-large-play-button", 3000);
    }
}
