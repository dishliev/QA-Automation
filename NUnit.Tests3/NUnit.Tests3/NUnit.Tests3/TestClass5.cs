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
    public class TestClass5
    {
        [Test]
        public void DemoQARegistrationNegativeUploadFileTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://www.demoqa.com/registration/";


            IWebElement uploadPicButton = driver.FindElement(By.Id("profile_pic_10"));
            uploadPicButton.Click();
            driver.SwitchTo().ActiveElement().SendKeys(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe");


            IWebElement submitButton = driver.FindElement(By.XPath("//*[@id=\"pie_register\"]/li[14]/div/input"));
            submitButton.Click();

            IWebElement errorMessage = driver.FindElement(By.XPath("//*[@id=\"pie_register\"]/li[9]/div/div/span"));
            Assert.AreEqual("* Invalid File", errorMessage.Text);

            driver.Quit();
        }
    }
}
