using NUnit.Framework;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumWebDriverAdvanced.Models;
using SeleniumWebDriverAdvanced.Pages.HomePage;
using SeleniumWebDriverAdvanced.Pages.RegistrationPage;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebDriverAdvanced
{
    [TestFixture]
    public class DemoQATests
    {
        public IWebDriver driver;

        [SetUp]
        public void Init()
        {
            this.driver = new ChromeDriver();
        }

        [TearDown]
        public void CleanUp()
        {
            this.driver.Quit();
        }

        [Test, Property("Priority", 2)]
  
     public void NavigateToRegistrationPage()
     {
         var homePage = new HomePage(driver);
         var registrationPage = new RegistrationPage(driver);
         PageFactory.InitElements(this.driver, homePage);
  
         homePage.NavigateTo();
         homePage.RegirstratonButton.Click();
  
         registrationPage.AssertRegistrationPageIsOpen("Registration");
     }

        [Test, Property("Priority", 2)]
        [Author("Kiril Dishliev")]
        public void DemoQARegistrationWithoutNames()
        {
    

            var regPage = new RegistrationPage(driver);
            var user = AccessExcelData.GetTestData("DemoQARegistrationWithoutNames");

       
            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);

            regPage.AssertNamesErrorMessage("* This field is required");
        }

        [Test, Property("Priority", 2)]
        [Author("Kiril Dishliev")]
        public void DemoQARegistrationInvalidEmail()
        {
   

            var regPage = new RegistrationPage(driver);
            var user = AccessExcelData.GetTestData("DemoQARegistrationInvalidEmail");
            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);

            regPage.AssertEmailErrorMessage("* Invalid email address");
         
        }

        [Test, Property("Priority", 2)]
        [Author("Kiril Dishliev")]
        public void DemoQARegistrationWithoutEmail()
        {
      

            var regPage = new RegistrationPage(driver);
            var user = AccessExcelData.GetTestData("DemoQARegistrationWithoutEmail");

            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);

            regPage.AssertEmailMissingErrorMessage("* This field is required");

        }

        [Test, Property("Priority", 2)]
        [Author("Kiril Dishliev")]
        public void DemoQARegistrationIvalidUploadFile()
        {

            var regPage = new RegistrationPage(driver);
            var user = AccessExcelData.GetTestData("DemoQARegistrationIvalidUploadFile");


            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);

            regPage.AssertUploadFileErrorMessage("* Invalid File");

        }

        [Test, Property("Priority", 2)]
        [Author("Kiril Dishliev")]
        public void DemoQARegistrationInvalidPhone()
        {
       
            var regPage = new RegistrationPage(driver);
            var user = AccessExcelData.GetTestData("DemoQARegistrationInvalidPhone");
            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);

            regPage.AssertPhoneErrorMessage("* Minimum 10 Digits starting with Country Code");

        }

        [Test, Property("Priority", 1)]
        [Author("Kiril Dishliev")]
        public void DemoQARegistrationWithoutPassword()
        {
       
        
            var regPage = new RegistrationPage(driver);
            var user = AccessExcelData.GetTestData("DemoQARegistrationWithoutPassword");

            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);

            regPage.AssertPasswordErrorMessage("* This field is required");

        }

        [Test, Property("Priority", 1)]
        [Author("Kiril Dishliev")]
        public void DemoQARegistrationWithoutConfirmPassword()
        {
      
            var regPage = new RegistrationPage(driver);
            var user = AccessExcelData.GetTestData("DemoQARegistrationWithoutConfirmPassword");

            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);

            regPage.AssertConfirmPasswordErrorMessage("* This field is required");

        }
        
        [Test, Property("Priority", 1)]
        [Author("Kiril Dishliev")]
        public void DemoQARegistrationPasswordMinimumCharacters()
        {
       
            var regPage = new RegistrationPage(driver);
            var user = AccessExcelData.GetTestData("DemoQARegistrationPasswordMinimumCharacters");

            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);

            regPage.AssertPasswordMinimumCharactersErrorMessage("* Minimum 8 characters required");

        }

        [Test, Property("Priority", 1)]
        [Author("Kiril Dishliev")]
          public void DemoQARegistrationPasswordFieldsDoNotMatch()
          {
          
              var regPage = new RegistrationPage(driver);
              var user = AccessExcelData.GetTestData("DemoQARegistrationPasswordFieldsDoNotMatch");

              regPage.NavigateTo();
              regPage.FillRegistrationForm(user);

              regPage.AssertPasswordFieldsDoNotMatchErrorMessage("* Fields do not match");

          }

        [Test, Property("Priority", 2)]
        [Author("Kiril Dishliev")]
          public void DemoQARegistrationHobby()
          {
              var regPage = new RegistrationPage(driver);
              var user = AccessExcelData.GetTestData("DemoQARegistrationHobby");
             

              regPage.NavigateTo();
              regPage.FillRegistrationForm(user);



              regPage.AssertHobbyErrorMessage("* This field is required");
          }

        [Test, Property("Priority", 2)]
        [Author("Kiril Dishliev")]
        public void DemoQARegistrationWithoutNamesAndPhone()
          {

              var regPage = new RegistrationPage(driver);
              var user = AccessExcelData.GetTestData("DemoQARegistrationWithoutNamesAndPhone");
             

              regPage.NavigateTo();
              regPage.FillRegistrationForm(user);

              regPage.AssertNamesErrorMessage("* This field is required");
              regPage.AssertPhoneErrorMessage("* This field is required");
          }

        [Test, Property("Priority", 2)]
        [Author("Kiril Dishliev")]
        public void DemoQARegistrationWithoutPhone()
          {
              var regPage = new RegistrationPage(driver);
              var user = AccessExcelData.GetTestData("DemoQARegistrationWithoutPhone"); 

              regPage.NavigateTo();
              regPage.FillRegistrationForm(user);

              regPage.AssertPhoneErrorMessage("* This field is required");
          }

        [Test, Property("Priority", 2)]
        [Author("Kiril Dishliev")]
        public void DemoQARegistrationWithoutNamesAndEmail()
          {

              var regPage = new RegistrationPage(driver);
              var user = AccessExcelData.GetTestData("DemoQARegistrationWithoutNamesAndEmail"); 

              regPage.NavigateTo();
              regPage.FillRegistrationForm(user);

              regPage.AssertNamesErrorMessage("* This field is required");
              regPage.AssertEmailErrorMessage("* This field is required");
          }

        [Test, Property("Priority", 1)]
        [Author("Kiril Dishliev")]
        public void DemoQARegistrationWithoutPhoneAndEmail()
        {

            var regPage = new RegistrationPage(driver);
            var user = AccessExcelData.GetTestData("DemoQARegistrationWithoutPhoneAndEmail"); 

            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);

            regPage.AssertPhoneErrorMessage("* This field is required");
            regPage.AssertEmailErrorMessage("* This field is required");
        }

        [Test, Property("Priority", 1)]
        [Author("Kiril Dishliev")]
          public void DemoQARegistrationPasswordMinimumCharactersAndWithoutConfirmPassword()
        {
            var regPage = new RegistrationPage(driver);
            var user = AccessExcelData.GetTestData("DemoQARegistrationPasswordMinimumCharactersAndWithoutConfirmPassword"); 

            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);

            regPage.AssertPasswordMinimumCharactersErrorMessage("* Minimum 8 characters required");
            regPage.AssertConfirmPasswordErrorMessage("* This field is required");
        }

        [Test, Property("Priority", 1)]
        [Author("Kiril Dishliev")]
         public void DemoQARegistrationUsernameAlreadyExsist()
         {
             var regPage = new RegistrationPage(driver);
             var user = AccessExcelData.GetTestData("DemoQARegistrationUsernameAlreadyExsist"); 

        regPage.NavigateTo();
        regPage.FillRegistrationForm(user);

        regPage.AssertUserNameAlreadyExsistErrorMessage("Error: Username already exists");
        }

        [Test, Property("Priority", 1)]
        [Author("Kiril Dishliev")]
        public void DemoQARegistrationWithoutUsername()
        {
            var regPage = new RegistrationPage(driver);
            var user = AccessExcelData.GetTestData("DemoQARegistrationWithoutUsername"); 
     
            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);
     
            regPage.AssertMissingUserName("* This field is required");
        }

        [Test, Property("Priority", 2)]
        [Author("Kiril Dishliev")]
        public void DemoQARegistrationWithoutFirstName()
        {
            var regPage = new RegistrationPage(driver);
            var user = AccessExcelData.GetTestData("DemoQARegistrationWithoutFirstName"); 
          
      
            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);
            regPage.FirstName.Click();
            regPage.RegistrationForm.Click();
            
            regPage.AssertNamesErrorMessage("* This field is required");
        }

        [Test, Property("Priority", 3)]
        [Author("Kiril Dishliev")]
        public void DemoQARegistrationWithoutNamesEmailPassword()
        {
            var regPage = new RegistrationPage(driver);
            var user = AccessExcelData.GetTestData("DemoQARegistrationWithoutNamesEmailPassword"); 
      
            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);
      
            regPage.AssertNamesErrorMessage("* This field is required");
            regPage.AssertEmailMissingErrorMessage("* This field is required");
            regPage.AssertPasswordErrorMessage("* This field is required");
        }

        [Test, Property("Priority", 2)]
        [Author("Kiril Dishliev")]
        public void DemoQARegistrationWithoutLastName()
        {
            var regPage = new RegistrationPage(driver);
            var user = AccessExcelData.GetTestData("DemoQARegistrationWithoutLastName"); 
      
            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);
      
            regPage.AssertNamesErrorMessage("* This field is required");
        }

        [Test, Property("Priority", 2)]
        [Author("Kiril Dishliev")]
        public void DemoQARegistrationEmailAlreadyExsist()
        {
            var regPage = new RegistrationPage(driver);
            var user = AccessExcelData.GetTestData("DemoQARegistrationEmailAlreadyExsist");

            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);

            regPage.AssertEmailAlreadyExsist("Error: E-mail address already exists");
        }

        [TearDown]
        public void CleanUp1()
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
                screenshot.SaveAsFile(filename + TestContext.CurrentContext.Test.Name + ".jpg", ScreenshotImageFormat.Jpeg);
            }

        }
        
    }
}
