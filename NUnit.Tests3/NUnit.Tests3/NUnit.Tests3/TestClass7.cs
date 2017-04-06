using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit.Tests3
{
    [TestFixture]
    public class TestClass7
    {
        [Test]
        public void SeleniumGoogleSearch()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://google.bg";


            IWebElement search = driver.FindElement(By.Name("q"));
            search.Clear();

            search.SendKeys("Selenium");

            driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            IWebElement firstElem = wait.Until<IWebElement>
                ((c) =>
                {
                    return c.FindElement(By.XPath("//*[@id=\"rso\"]/div[1]/div/div/div/h3/a"));
                }
                );


            firstElem.Click();
            Assert.AreEqual("http://www.seleniumhq.org/", driver.Url);
            Assert.AreEqual("Selenium - Web Browser Automation", driver.Title);
            driver.Quit();

        }
    }
}
