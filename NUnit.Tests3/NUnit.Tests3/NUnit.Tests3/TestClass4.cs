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
    public class TestClass4
    {
        [Test]
        public void DemoQARegistrationNegativePasswordTest()
        {
                IWebDriver driver = new ChromeDriver();
         
            driver.Url = "http://www.demoqa.com/registration";

            IWebElement password = driver.FindElement(By.Id("password_2"));
            password.Click();
            Type(password, "23325");
          
           IWebElement confirmPassword = driver.FindElement(By.Id("confirm_password_password_2"));
            confirmPassword.Click();
            Type(confirmPassword,"2342");

            IWebElement submitButton = driver.FindElement(By.XPath("//*[@id=\"pie_register\"]/li[14]/div/input"));
            submitButton.Click();


            IWebElement errorMessage = driver.FindElement(By.XPath("//*[@id=\"pie_register\"]/li[11]/div/div/span"));
            Assert.AreEqual("* Minimum 8 characters required", errorMessage.Text);

             IWebElement errorMessage1 = driver.FindElement(By.XPath("//*[@id=\"pie_register\"]/li[12]/div/div/span"));
            Assert.AreEqual("* Fields do not match", errorMessage1.Text);
            driver.Quit();




        }
        private void Type(IWebElement element, string text) {
            element.Clear();
            element.SendKeys(text);
        
        
        }
    }
}

        