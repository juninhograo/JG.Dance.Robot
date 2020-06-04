using OpenQA.Selenium.Chrome;

namespace JG.Dancing
{
    abstract class Robot: Behavior
    {
        public static void Load()
        {
            using (var driver = new ChromeDriver())
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
