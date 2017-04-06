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
    public class TestClass3
    {
        [Test]
        public void DemoQARegistrationNegativeEmailTest()
        {
             IWebDriver driver = new ChromeDriver();

            driver.Url = "http://www.demoqa.com/registration";

            IWebElement email = driver.FindElement(By.XPath("//*[@id=\"email_1\"]"));

            email.Click();
            Type(email, "zhivko.bg");

            IWebElement submitButton = driver.FindElement(By.XPath("//*[@id=\"pie_register\"]/li[14]/div/input"));
            submitButton.Click();
         
            IWebElement errorMessage = driver.FindElement(By.XPath("//*[@id=\"pie_register\"]/li[8]/div/div/span"));

            Assert.AreEqual("* Invalid email address", errorMessage.Text);
            driver.Quit();

            
        }
        private void Type(IWebElement element, string text) {
            element.Clear();
            element.SendKeys(text);
        
        }
    }
}
