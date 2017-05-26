using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diana_ltd.comTests.Pages.ContactForm
{
    public partial class ContactFormPage
    {
        public IWebElement Name
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"FormName\"]"));
            }
        }
        public IWebElement Email
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"FormEmail\"]"));
            }
        }
        public IWebElement Telephone
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"FormPhone\"]"));
            }
        }
        public IWebElement Message
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"FormMessage\"]"));
            }
        }
        public IWebElement SendButton
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"contactsform\"]/a"));
            }
        }
         public IWebElement ErrorMessageEmail
        {
            get
            {
                return this.Driver.FindElement(By.XPath("/html/body/div[5]/h2"));
            }
        }
       public IWebElement MessageSuccessSend
        {
            get
            {
                return this.Driver.FindElement(By.XPath("/html/body/div[2]/h2"));
            }
        }
    }
}
