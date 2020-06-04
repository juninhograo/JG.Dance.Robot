using OpenQA.Selenium.Chrome;
using System;
using System.Configuration;
using System.Threading;

namespace JG.Dancing.Core
{
    internal abstract class Utils
    {
        internal static readonly string YOUTUBE_VIDEO_URL = ConfigurationManager.AppSettings["YOUTUBE_VIDEO_URL"].ToString();
        internal static readonly string ROBOT_DANCING_URL = ConfigurationManager.AppSettings["ROBOT_DANCING_URL"].ToString();
        internal static readonly int WAIT_VIDEO_TIME = Convert.ToInt32(ConfigurationManager.AppSettings["WAIT_VIDEO_TIME"].ToString());

        internal static void ActionButton(ChromeDriver driver, string buttonName, int waitTime)
        {
            try
            {
                Thread.Sleep(waitTime);
                var playButton = driver.FindElementByCssSelector(buttonName);
                if (playButton != null)
                    playButton.Click();
            }
            catch (System.Exception)
            {
                Console.WriteLine($"Small error! The button {buttonName} is not there!");
            }
        }
    }
}
