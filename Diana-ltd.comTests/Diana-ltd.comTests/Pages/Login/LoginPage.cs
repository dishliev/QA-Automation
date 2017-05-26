using Diana_ltd.comTests.Models;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diana_ltd.comTests.Pages.Login
{
    public partial class LoginPage : BasePage
    {
        public LoginPage(IWebDriver driver)
            : base(driver)
        {
            AccessExcelData.fileName = "LoginData.xlsx";
        }

        public string URL
        {
            get
            {
                return url + "sign_up?enter";
            }
        }

        public void NavigateTo()
        {
            this.Driver.Navigate().GoToUrl(this.URL);
        }

        
        public void FillLoginForm(LoginFormUser user)
        {

            Type(Email, user.Email);
            Type(Password, user.Password);

            SubmitButton.Click();
        }
        private void Type(IWebElement element, string text)
        {
            string fieldEmpty = "String.Empty";

            element.Click();
            if (!text.Equals(fieldEmpty))
            {

                element.SendKeys(text);


            }
        }
    }
}
