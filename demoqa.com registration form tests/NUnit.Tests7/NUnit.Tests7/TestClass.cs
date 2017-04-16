using NUnit.Framework;
using NUnit.Tests7.Models;
using NUnit.Tests7.Pages.HomePage;
using NUnit.Tests7.Pages.RegistrationPage;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit.Tests7
{
    [TestFixture]
    public class RegisterInDemoQA
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

        [Test, Property("Priority", 1)]

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
            var regPage = new RegistrationPage(this.driver);
            RegistrationUser user = new RegistrationUser("",
                                                         "",
                                                         new List<bool>(new bool[] { true, false, false }),
                                                         new List<bool>(new bool[] { true, false, true }),
                                                         "Bulgaria",
                                                         "4",
                                                         "14",
                                                         "1991",
                                                         "1111111112",
                                                         "disliev",
                                                         "mx_k@abv.bg",
                                                         @"C:\Users\DISHLIEV\Desktop\111.png",
                                                         "fasdfd",
                                                         "sdfvsdfv",
                                                         "sdfvsdfv");

            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);

            regPage.AssertNamesErrorMessage("* This field is required");
        }

        [Test, Property("Priority", 2)]
        [Author("Kiril Dishliev")]
        public void DemoQARegistrationInvalidEmail()
        {
            var regPage = new RegistrationPage(this.driver);
            RegistrationUser user = new RegistrationUser("Kiril",
                                                         "Dishliev",
                                                         new List<bool>(new bool[] { true, false, false }),
                                                         new List<bool>(new bool[] { true, false, true }),
                                                         "Bulgaria",
                                                         "4",
                                                         "14",
                                                         "1991",
                                                         "1111111112",
                                                         "disliev",
                                                         "emailemail",
                                                         @"C:\Users\DISHLIEV\Desktop\111.png",
                                                         "ffasdd",
                                                         "sdfvsdfv",
                                                         "sdfvsdfv");

            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);

            regPage.AssertEmailErrorMessage("* Invalid email address");
         
        }

        [Test, Property("Priority", 2)]
        [Author("Kiril Dishliev")]
        public void DemoQARegistrationWithoutEmail()
        {
            var regPage = new RegistrationPage(this.driver);
            RegistrationUser user = new RegistrationUser("Kiril",
                                                         "Dishliev",
                                                         new List<bool>(new bool[] { true, false, false }),
                                                         new List<bool>(new bool[] { true, false, true }),
                                                         "Bulgaria",
                                                         "4",
                                                         "14",
                                                         "1991",
                                                         "1111111112",
                                                         "disliev",
                                                         "",
                                                         @"C:\Users\DISHLIEV\Desktop\111.png",
                                                         "ffasdd",
                                                         "sdfvsdfv",
                                                         "sdfvsdfv");

            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);

            regPage.AssertEmailMissingErrorMessage("* This field is required");

        }

        [Test, Property("Priority", 2)]
        [Author("Kiril Dishliev")]
        public void DemoQARegistrationIvalidUploadFile()
        {
            var regPage = new RegistrationPage(this.driver);
            RegistrationUser user = new RegistrationUser("Kiril",
                                                         "Dishliev",
                                                         new List<bool>(new bool[] { true, false, false }),
                                                         new List<bool>(new bool[] { true, false, true }),
                                                         "Bulgaria",
                                                         "4",
                                                         "14",
                                                         "1991",
                                                         "1111111112",
                                                         "disliev",
                                                         "emailemail@abv.bg",
                                                         @"C:\Users\DISHLIEV\Desktop\chrome.exe",
                                                         "ffasdd",
                                                         "sdfvsdfv",
                                                         "sdfvsdfv");

            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);

            regPage.AssertUploadFileErrorMessage("* Invalid File");

        }

        [Test, Property("Priority", 2)]
        [Author("Kiril Dishliev")]
        public void DemoQARegistrationInvalidPhone()
        {
            var regPage = new RegistrationPage(this.driver);
            RegistrationUser user = new RegistrationUser("Kiril",
                                                         "Dishliev",
                                                         new List<bool>(new bool[] { true, false, false }),
                                                         new List<bool>(new bool[] { true, false, true }),
                                                         "Bulgaria",
                                                         "4",
                                                         "14",
                                                         "1991",
                                                         "1112",
                                                         "disliev",
                                                         "emailemail@abv.bg",
                                                         @"C:\Users\DISHLIEV\Desktop\111.png",
                                                         "ffasdd",
                                                         "sdfvsdfv",
                                                         "sdfvsdfv");

            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);

            regPage.AssertPhoneErrorMessage("* Minimum 10 Digits starting with Country Code");

        }

        [Test, Property("Priority", 1)]
        [Author("Kiril Dishliev")]
        public void DemoQARegistrationWithoutPassword()
        {
            var regPage = new RegistrationPage(this.driver);
            RegistrationUser user = new RegistrationUser("Kiril",
                                                         "Dishliev",
                                                         new List<bool>(new bool[] { true, false, false }),
                                                         new List<bool>(new bool[] { true, false, true }),
                                                         "Bulgaria",
                                                         "4",
                                                         "14",
                                                         "1991",
                                                         "11123452345",
                                                         "disliev",
                                                         "emailemail@abv.bg",
                                                         @"C:\Users\DISHLIEV\Desktop\111.png",
                                                         "ffasdd",
                                                         "",
                                                         "sdfvsdfv");

            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);

            regPage.AssertPasswordErrorMessage("* This field is required");

        }

        [Test, Property("Priority", 1)]
        [Author("Kiril Dishliev")]
        public void DemoQARegistrationWithoutConfirmPassword()
        {
            var regPage = new RegistrationPage(this.driver);
            RegistrationUser user = new RegistrationUser("Kiril",
                                                         "Dishliev",
                                                         new List<bool>(new bool[] { true, false, false }),
                                                         new List<bool>(new bool[] { true, false, true }),
                                                         "Bulgaria",
                                                         "4",
                                                         "14",
                                                         "1991",
                                                         "11123452345",
                                                         "disliev",
                                                         "emailemail@abv.bg",
                                                         @"C:\Users\DISHLIEV\Desktop\111.png",
                                                         "ffasdd",
                                                         "asdvasdvasd",
                                                         "");

            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);

            regPage.AssertConfirmPasswordErrorMessage("* This field is required");

        }
        
        [Test, Property("Priority", 1)]
        [Author("Kiril Dishliev")]
        public void DemoQARegistrationPasswordMinimumCharacters()
        {
            var regPage = new RegistrationPage(this.driver);
            RegistrationUser user = new RegistrationUser("Kiril",
                                                         "Dishliev",
                                                         new List<bool>(new bool[] { true, false, false }),
                                                         new List<bool>(new bool[] { true, false, true }),
                                                         "Bulgaria",
                                                         "4",
                                                         "14",
                                                         "1991",
                                                         "11123452345",
                                                         "disliev",
                                                         "emailemail@abv.bg",
                                                         @"C:\Users\DISHLIEV\Desktop\111.png",
                                                         "ffasdd",
                                                         "asd",
                                                         "asd");

            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);

            regPage.AssertPasswordMinimumCharactersErrorMessage("* Minimum 8 characters required");

        }

        [Test, Property("Priority", 1)]
        [Author("Kiril Dishliev")]
          public void DemoQARegistrationPasswordFieldsDoNotMatch()
          {
              var regPage = new RegistrationPage(this.driver);
              RegistrationUser user = new RegistrationUser("Kiril",
                                                           "Dishliev",
                                                           new List<bool>(new bool[] { true, false, false }),
                                                           new List<bool>(new bool[] { true, false, true }),
                                                           "Bulgaria",
                                                           "4",
                                                           "14",
                                                           "1991",
                                                           "11123452345",
                                                           "disliev",
                                                           "emailemail@abv.bg",
                                                           @"C:\Users\DISHLIEV\Desktop\111.png",
                                                           "ffasdd",
                                                           "asdadvasv",
                                                           "asdasdvasasvd");

              regPage.NavigateTo();
              regPage.FillRegistrationForm(user);

              regPage.AssertPasswordFieldsDoNotMatchErrorMessage("* Fields do not match");

          }

        [Test, Property("Priority", 2)]
        [Author("Kiril Dishliev")]
          public void DemoQARegistrationHobby()
          {
              var regPage = new RegistrationPage(this.driver);
              RegistrationUser user = new RegistrationUser("Kiril",
                                                           "Dishliev",
                                                           new List<bool>(new bool[] { true, false, false }),
                                                           new List<bool>(new bool[] { false, false, false }),
                                                           "Bulgaria",
                                                           "4",
                                                           "14",
                                                           "1991",
                                                           "11123452345",
                                                           "disliev",
                                                           "emailemadsl@abv.bg",
                                                           @"C:\Users\DISHLIEV\Desktop\111.png",
                                                           "ffasddd",
                                                           "asdadvasv",
                                                           "asdadvasv");

              regPage.NavigateTo();
              regPage.FillRegistrationForm(user);



              regPage.AssertHobbyErrorMessage("* This field is required");
          }

        [Test, Property("Priority", 2)]
        [Author("Kiril Dishliev")]
        public void DemoQARegistrationWithoutNamesAndPhone()
          {
              var regPage = new RegistrationPage(this.driver);
              RegistrationUser user = new RegistrationUser("",
                                                           "",
                                                           new List<bool>(new bool[] { true, false, false }),
                                                           new List<bool>(new bool[] { true, false, true }),
                                                           "Bulgaria",
                                                           "4",
                                                           "14",
                                                           "1991",
                                                           "",
                                                           "disliev",
                                                           "mx_k@abv.bg",
                                                           @"C:\Users\DISHLIEV\Desktop\111.png",
                                                           "fasdfd",
                                                           "sdfvsdfv",
                                                           "sdfvsdfv");

              regPage.NavigateTo();
              regPage.FillRegistrationForm(user);

              regPage.AssertNamesErrorMessage("* This field is required");
              regPage.AssertPhoneErrorMessage("* This field is required");
          }

        [Test, Property("Priority", 2)]
        [Author("Kiril Dishliev")]
        public void DemoQARegistrationWithoutPhone()
          {
              var regPage = new RegistrationPage(this.driver);
              RegistrationUser user = new RegistrationUser("Kiril",
                                                           "Dishliev",
                                                           new List<bool>(new bool[] { true, false, false }),
                                                           new List<bool>(new bool[] { true, false, true }),
                                                           "Bulgaria",
                                                           "4",
                                                           "14",
                                                           "1991",
                                                           "",
                                                           "disliev",
                                                           "mx_k@abv.bg",
                                                           @"C:\Users\DISHLIEV\Desktop\111.png",
                                                           "fasdfd",
                                                           "sdfvsdfv",
                                                           "sdfvsdfv");

              regPage.NavigateTo();
              regPage.FillRegistrationForm(user);

              regPage.AssertPhoneErrorMessage("* This field is required");
          }

        [Test, Property("Priority", 2)]
        [Author("Kiril Dishliev")]
        public void DemoQARegistrationWithoutNamesAndEmail()
          {
              var regPage = new RegistrationPage(this.driver);
              RegistrationUser user = new RegistrationUser("",
                                                           "",
                                                           new List<bool>(new bool[] { true, false, false }),
                                                           new List<bool>(new bool[] { true, false, true }),
                                                           "Bulgaria",
                                                           "4",
                                                           "14",
                                                           "1991",
                                                           "234523452345",
                                                           "disliev",
                                                           "",
                                                           @"C:\Users\DISHLIEV\Desktop\111.png",
                                                           "fasdfd",
                                                           "sdfvsdfv",
                                                           "sdfvsdfv");

              regPage.NavigateTo();
              regPage.FillRegistrationForm(user);

              regPage.AssertNamesErrorMessage("* This field is required");
              regPage.AssertEmailErrorMessage("* This field is required");
          }

        [Test, Property("Priority", 1)]
        [Author("Kiril Dishliev")]
        public void DemoQARegistrationWithoutPhoneAndEmail()
        {
            var regPage = new RegistrationPage(this.driver);
            RegistrationUser user = new RegistrationUser("Kiril",
                                                         "Dishliev",
                                                         new List<bool>(new bool[] { true, false, false }),
                                                         new List<bool>(new bool[] { true, false, true }),
                                                         "Bulgaria",
                                                         "4",
                                                         "14",
                                                         "1991",
                                                         "",
                                                         "disliev",
                                                         "",
                                                         @"C:\Users\DISHLIEV\Desktop\111.png",
                                                         "fasdfd",
                                                         "sdfvsdfv",
                                                         "sdfvsdfv");

            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);

            regPage.AssertPhoneErrorMessage("* This field is required");
            regPage.AssertEmailErrorMessage("* This field is required");
        }

        [Test, Property("Priority", 1)]
        [Author("Kiril Dishliev")]
        public void DemoQARegistrationPasswordMinimumCharactersAndWithoutConfirmPassword()
        {
            var regPage = new RegistrationPage(this.driver);
            RegistrationUser user = new RegistrationUser("Kiril",
                                                         "Dishliev",
                                                         new List<bool>(new bool[] { true, false, false }),
                                                         new List<bool>(new bool[] { true, false, true }),
                                                         "Bulgaria",
                                                         "4",
                                                         "14",
                                                         "1991",
                                                         "234234243234",
                                                         "disliev",
                                                         "mx_k@abv.bg",
                                                         @"C:\Users\DISHLIEV\Desktop\111.png",
                                                         "fasdfd",
                                                         "sfv",
                                                         "");

            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);

            regPage.AssertPasswordMinimumCharactersErrorMessage("* Minimum 8 characters required");
            regPage.AssertConfirmPasswordErrorMessage("* This field is required");
        }

        [Test, Property("Priority", 1)]
        [Author("Kiril Dishliev")]
         public void DemoQARegistrationUsernameAlreadyExsist()
         {
               var regPage = new RegistrationPage(this.driver);
               RegistrationUser user = new RegistrationUser("Kiril",
                                                        "Dishliev",
                                                         new List<bool>(new bool[] { true, false, false }),
                                                         new List<bool>(new bool[] { true, false, true }),
                                                        "Bulgaria",
                                                        "4",
                                                        "14",
                                                        "1991",
                                                        "234234243234",
                                                        "dishliev1",
                                                        "mx_k@abv.bg",
                                                        "",
                                                        "fasdfd",
                                                        "4449071p",
                                                        "4449071p");

        regPage.NavigateTo();
        regPage.FillRegistrationForm(user);

        regPage.AssertUserNameAlreadyExsistErrorMessage("Error: Username already exists");
    }

        [Test, Property("Priority", 1)]
        [Author("Kiril Dishliev")]
        public void DemoQARegistrationWithoutUsername()
        {
            var regPage = new RegistrationPage(this.driver);
            RegistrationUser user = new RegistrationUser("Kiril",
                                                         "Dishliev",
                                                         new List<bool>(new bool[] { true, false, false }),
                                                         new List<bool>(new bool[] { true, false, true }),
                                                         "Bulgaria",
                                                         "4",
                                                         "14",
                                                         "1991",
                                                         "234234243234",
                                                         "",
                                                         "mx_k@abv.bg",
                                                         @"C:\Users\DISHLIEV\Desktop\111.png",
                                                         "fasdfd",
                                                         "4449071p",
                                                         "4449071p");
     
            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);
     
            regPage.AssertMissingUserName("* This field is required");
        }

        [Test, Property("Priority", 2)]
        [Author("Kiril Dishliev")]
        public void DemoQARegistrationWithoutFirstName()
        {
            var regPage = new RegistrationPage(this.driver);
            RegistrationUser user = new RegistrationUser("",
                                                         "Dishliev",
                                                         new List<bool>(new bool[] { true, false, false }),
                                                         new List<bool>(new bool[] { true, false, true }),
                                                         "Bulgaria",
                                                         "4",
                                                         "14",
                                                         "1991",
                                                         "234234243234",
                                                         "dislievs1",
                                                         "mx_k@abv.bg",
                                                         @"C:\Users\DISHLIEV\Desktop\111.png",
                                                         "fasdfd",
                                                         "4449071p",
                                                         "4449071p");
      
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
            var regPage = new RegistrationPage(this.driver);
            RegistrationUser user = new RegistrationUser("",
                                                         "",
                                                         new List<bool>(new bool[] { true, false, false }),
                                                         new List<bool>(new bool[] { true, false, true }),
                                                         "Bulgaria",
                                                         "4",
                                                         "14",
                                                         "1991",
                                                         "234234243234",
                                                         "dislievs1",
                                                         "",
                                                         @"C:\Users\DISHLIEV\Desktop\111.png",
                                                         "fasdfd",
                                                         "",
                                                         "");
      
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
            var regPage = new RegistrationPage(this.driver);
            RegistrationUser user = new RegistrationUser("Kiril",
                                                         "",
                                                         new List<bool>(new bool[] { true, false, false }),
                                                         new List<bool>(new bool[] { true, false, true }),
                                                         "Bulgaria",
                                                         "4",
                                                         "14",
                                                         "1991",
                                                         "1111111112",
                                                         "disliev",
                                                         "mx_k@abv.bg",
                                                         @"C:\Users\DISHLIEV\Desktop\111.png",
                                                         "fasdfd",
                                                         "sdfvsdfv",
                                                         "sdfvsdfv");
      
            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);
      
            regPage.AssertNamesErrorMessage("* This field is required");
        }
    }
}
