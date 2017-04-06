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
    public class TestClass2
    {
        [Test]
        public void DemoQARegistrationNegativePhoneNumberTest()
        {

            IWebDriver driver = new ChromeDriver();

            driver.Url = "http://www.demoqa.com/registration";

            IWebElement phoneNumber = driver.FindElement(By.XPath("//*[@id=\"phone_9\"]"));

            phoneNumber.Click();
            Type(phoneNumber, "8888");

           

            IWebElement submitButton = driver.FindElement(By.XPath("//*[@id=\"pie_register\"]/li[14]/div/input"));
            submitButton.Click();
         
            IWebElement errorMessage = driver.FindElement(By.XPath("//*[@id=\"pie_register\"]/li[6]/div/div/span"));
            
            Assert.AreEqual("* Minimum 10 Digits starting with Country Code", errorMessage.Text);
            driver.Quit();

            
        }
        private void Type(IWebElement element, string text) {
            element.Clear();
            element.SendKeys(text);
        
        }
    }
}
