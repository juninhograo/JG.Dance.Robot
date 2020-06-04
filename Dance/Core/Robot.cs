using OpenQA.Selenium.Chrome;

namespace JG.Dancing.Core
{
    abstract class Robot: Behavior
    {
        public static void Load()
        {
            var options = new ChromeOptions();
            options.AddArgument("--start-maximized");

            using (var driver = new ChromeDriver(options))
            {
                //open a YouTube video
                driver.Navigate().GoToUrl(YOUTUBE_VIDEO_URL);

                //press play button
                PlayVideo(driver);

                //press skip button
                SkipAdvertisement(driver);

                //Dance robot, dance
                DanceRobot(driver);
            }
        }

    }
}
