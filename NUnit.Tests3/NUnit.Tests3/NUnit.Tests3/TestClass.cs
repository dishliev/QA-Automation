using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit.Tests3
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void DemoQaRegistrationPage()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://www.demoqa.com";

            var registration = driver.FindElement(By.XPath("//*[@id=\"menu-item-374\"]/a"));
            registration.Click();

            var registrationOpen = driver.FindElement(By.XPath("//*[@id=\"post-49\"]/div"));

            Assert.IsTrue(registrationOpen.Displayed);
            driver.Quit();

        }
    }
}
