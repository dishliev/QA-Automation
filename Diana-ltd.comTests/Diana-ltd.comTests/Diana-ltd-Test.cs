using Diana_ltd.comTests.Models;
using Diana_ltd.comTests.Pages.ContactForm;
using Diana_ltd.comTests.Pages.Login;
using Diana_ltd.comTests.Pages.SearchBySize;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;



namespace Diana_ltd.comTests
{

    public class TestClass
    {
        [TestFixture]
        public class TestClass1
        {
            public IWebDriver driver;
           

            [SetUp]
            public void Init()
            {
                this.driver = new ChromeDriver();
            }

            //SEARCH BY SIZE

            [Test, Property("SearchBySize", 1)]
            [Author("Kiril Dishliev")]
            public void TyreSizeSearchResult()
            {

                var searchTyre = new SearchBySizePage(driver);
                var tyre = AccessExcelData.GetTestDataTyre("TyreSizeSearchResult");

                searchTyre.NavigateTo();
              
                searchTyre.FillFormSearchTyre(tyre);
                
                searchTyre.AssertTyreSizeSearchResult("195/65 R15");
            }

            [Test, Property("SearchBySize", 1)]
            [Author("Kiril Dishliev")]
            public void RunflatSearchResult()
            {

                var searchTyre = new SearchBySizePage(driver);

                searchTyre.NavigateTo();
                searchTyre.RunflatBoxSelect();

                searchTyre.AssertRunflatSearchResult();
            }

            [Test, Property("SearchBySize", 1)]
            [Author("Kiril Dishliev")]
            public void XLSearchResult()
            {

                var searchTyre = new SearchBySizePage(driver);

                searchTyre.NavigateTo();
                searchTyre.XLBoxSelect();

                searchTyre.AssertXLSearchResult();
            }
            [Test, Property("SearchBySize", 1)]
            [Author("Kiril Dishliev")]
            public void RunflatAndXLSearchResult()
            {

                var searchTyre = new SearchBySizePage(driver);             

                searchTyre.NavigateTo();
                searchTyre.RUnflatAndXLBoxSelect();

                searchTyre.AssertRunflatSearchResult();
                searchTyre.AssertXLSearchResult();
              
            }

            // LOGIN TESTS

            [Test, Property("Login", 1)]
            [Author("Kiril Dishliev")]
            public void LoginWithInvalidEmail()
            {

                var loginPage = new LoginPage(driver);
                var user = AccessExcelData.GetTestDataLogin("LoginWithInvalidEmail");
             
                loginPage.NavigateTo();
                loginPage.FillLoginForm(user);

                loginPage.AssertErrorMessageEmail("Моля, въведете валиден имейл");
            }

            [Test, Property("Login", 1)]
            [Author("Kiril Dishliev")]
            public void LoginWithoutEmail()
            {

                var loginPage = new LoginPage(driver);
                var user = AccessExcelData.GetTestDataLogin("LoginWithoutEmail");

                loginPage.NavigateTo();
                loginPage.FillLoginForm(user);

                loginPage.AssertErrorMessageEmail("Моля, въведете валиден имейл");
            }

            [Test, Property("Login", 1)]
            [Author("Kiril Dishliev")]
            public void LoginWithoutPassword()
            {

                var loginPage = new LoginPage(driver);
                var user = AccessExcelData.GetTestDataLogin("LoginWithoutPassword");

                loginPage.NavigateTo();
                loginPage.FillLoginForm(user);

                loginPage.AssertErrorShortPassword("Въведената парола е твърде къса");
            }

            [Test, Property("Login", 1)]
            [Author("Kiril Dishliev")]
            public void LoginWithoutEmailAndPassword()
            {
                var loginPage = new LoginPage(driver);
                var user = AccessExcelData.GetTestDataLogin("LoginWithoutEmailAndPassword");

                loginPage.NavigateTo();
                loginPage.FillLoginForm(user);

                loginPage.AssertErrorMessageEmail("Моля, въведете валиден имейл");
            }
        
        // CONTACT FORM TESTS

            [Test, Property("ContactForm", 1)]
            [Author("Kiril Dishliev")]
            public void ContactFormWithoutEmail()
            {

                var contactForm = new ContactFormPage(driver);
                var user = AccessExcelData.GetTestDataContactForm("ContactFormWithoutEmail");

                contactForm.NavigateTo();       
                contactForm.FillContactForm(user);

                contactForm.AssertErrorMessageForEmail("Моля, въведете вашия e-mail адрес!");
            }
     
            [Test, Property("ContactForm", 1)]
            [Author("Kiril Dishliev")]
            public void ContactFormWithInvalidEmail()
            {

                var contactForm = new ContactFormPage(driver);
                var user = AccessExcelData.GetTestDataContactForm("ContactFormWithInvalidEmail");

                contactForm.NavigateTo();
                contactForm.FillContactForm(user);

                contactForm.AssertErrorMessageForEmail("Имейлът изглежда неправилен. Проверете за @");
            }

            [Test, Property("ContactForm", 1)]
            [Author("Kiril Dishliev")]
            public void ContactFormWithValidData()
            {
                var contactForm = new ContactFormPage(driver);
                var user = AccessExcelData.GetTestDataContactForm("ContactFormWithValidData");

                contactForm.NavigateTo();
                contactForm.FillContactForm(user);

                contactForm.AssertMessageForSuccessSend("Запитването беше изпратено успешно!");
            }
            

            [TearDown]
            public void CleanUp()
            {
                if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                {
                    string filename = ConfigurationManager.AppSettings["Logs"] + TestContext.CurrentContext.Test.Name + ".txt";
                    if (File.Exists(filename))
                    {
                        File.Delete(filename);
                    }
                    File.WriteAllText(filename, TestContext.CurrentContext.Test.FullName + "        " + TestContext.CurrentContext.WorkDirectory + "            " + TestContext.CurrentContext.Result.PassCount);

                    var screenshot = ((ITakesScreenshot)this.driver).GetScreenshot();
                    var fileNameScreenshot = ConfigurationManager.AppSettings["Logs"] + TestContext.CurrentContext.Test.Name;

                    if (File.Exists(fileNameScreenshot))
                    {
                        File.Delete(fileNameScreenshot);
                    }

                    screenshot.SaveAsFile(fileNameScreenshot + ".jpeg", ScreenshotImageFormat.Jpeg);
                }

                driver.Quit();
            }
        }
    }
}
