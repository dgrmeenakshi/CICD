using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;

namespace SampleProject
{
    [TestFixture]
    public class Base
    {
        [Test]
        public void LaunchApplication()
        {
            IWebDriver driver = new ChromeDriver(@"C:\Meenakshi\SampleProject\packages\Selenium.WebDriver.ChromeDriver.101.0.4951.4100\driver\win32\");
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.google.com");
            driver.Quit();

        }
    }
}
