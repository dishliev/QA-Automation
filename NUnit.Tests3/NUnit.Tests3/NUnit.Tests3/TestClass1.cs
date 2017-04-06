using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;



namespace NUnit.Tests3
{
    [TestFixture]
    public class TestClass1
    {
        [Test]
        public void DemoQaRegistrationNegativeNameTest()
        {

            // first name and last name with empty field
            IWebDriver driver = new ChromeDriver();
         
            driver.Url = "http://www.demoqa.com/registration";

            IWebElement firstName = driver.FindElement(By.Id("name_3_firstname"));
            firstName.Click();
            Type(firstName, "   ");
          
           IWebElement lastName = driver.FindElement(By.Id("name_3_lastname"));
            lastName.Click();
            Type(lastName,"   ");

            IWebElement errorMessage = driver.FindElement(By.XPath("//*[@id=\"pie_register\"]/li[1]/div[1]/div[2]/span"));
            Assert.AreEqual("* This field is required", errorMessage.Text);
            driver.Quit();




        }
        private void Type(IWebElement element, string text) {
            element.Clear();
            element.SendKeys(text);
        
        
        }
    }
}
