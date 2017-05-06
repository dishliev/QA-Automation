using OpenQA.Selenium;
using SeleniumWebDriverAdvanced.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebDriverAdvanced.Pages.RegistrationPage
{
   public partial class RegistrationPage : BasePage
    {
           public RegistrationPage(IWebDriver driver)
            : base(driver)
        {
        }

        public void NavigateTo()
        {
            this.Driver.Navigate().GoToUrl("http://demoqa.com/registration/");
        }

        public void FillRegistrationForm(RegistrationUser user)
        {
            Type(FirstName, user.FirstName);
            Type(LastName, user.LastName);
            ClickOnElements(MartialStatus, user.MartialStatus);
            ClickOnElements(Hobbys, user.Hobbys);
            CountryOption.SelectByText(user.Country);
            MounthOption.SelectByText(user.BirthMonth);
            DayOption.SelectByText(user.BirthDay);
            YearOption.SelectByText(user.BirthYear);
            Type(Phone, user.Phone);
            Type(UserName, user.UserName);
            Type(Email, user.Email);
            UploadButton.Click();
            Driver.SwitchTo().ActiveElement().SendKeys(user.Picture);
            Type(Description, user.Description);
            Type(Password, user.Password);
            Type(ConfirmPassword, user.ConfirmPassword);
            SubmitButton.Click();
        }

        private void ClickOnElements(List<IWebElement> elements, string conditions)
        {

            var choices = conditions.Split();

            for (int i = 0; i < choices.Length; i++)
            {
                if (choices[i].Equals("true"))
                {
                    elements[i].Click();
                }
            }
        }
        

        private void Type(IWebElement element, string text)
        {
            string fieldEmpty = "Field-Empty";
   
            
            
        
            element.Click();
            if (!text.Equals(fieldEmpty))
            {

                element.SendKeys(text);

            
            }
        }


    }
}
