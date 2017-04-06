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
    public class TestClass6
    {
        [Test]
        public void SoftUniTagsContains()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://softuni.bg";
            var courses = driver.FindElement(By.XPath("//*[@id=\"header-nav\"]/div[1]/ul/li[2]/a/span"));
            courses.Click();
           
            var qaCourse = driver.FindElement(By.LinkText("QA Automation - март 2017"));
            qaCourse.Click();

            var firstHeading = driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div/div/h1"));
            Assert.AreEqual("Курс QA Automation - март 2017", firstHeading.Text);

            var secondHeading = driver.FindElement(By.XPath("/html/body/div[3]/div[2]/div/article/div[1]/h2"));
            Assert.AreEqual("Курс QA Automation - март 2017", secondHeading.Text);

            driver.Quit();
        }
    }
}
