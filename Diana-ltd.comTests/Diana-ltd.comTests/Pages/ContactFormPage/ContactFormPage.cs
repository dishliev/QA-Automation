using Diana_ltd.comTests.Models;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diana_ltd.comTests.Pages.ContactForm
{
    public partial class ContactFormPage : BasePage
    {
        public ContactFormPage(IWebDriver driver)
            : base(driver)
        {
            AccessExcelData.fileName = "ContactForm.xlsx";
        }

        public string URL
        {
            get
            {
                return url + "Sofiya-c158";
            }
        }

        public void NavigateTo()
        {
            this.Driver.Navigate().GoToUrl(this.URL);
        }
        public void FillContactForm(ContactFormUser user)
        {
           
            Type(Name, user.Name);       
            Type(Email, user.Email);
            Type(Telephone, user.Telephone);
            Type(Message, user.Message);


            SendButton.Click();
        }
        private void Type(IWebElement element, string text)
        {

            if (!text.Equals("String.Empty"))
            {
                element.SendKeys(text);

            }
        }
    }
}

   