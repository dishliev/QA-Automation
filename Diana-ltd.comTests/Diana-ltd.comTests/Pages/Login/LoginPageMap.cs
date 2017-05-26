using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diana_ltd.comTests.Pages.Login
{
    public partial class LoginPage
    {
        public IWebElement Email
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"email\"]"));
            }
        }
        public IWebElement Password
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"pass1\"]"));
            }
        }
        public IWebElement SubmitButton
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"LoginForm\"]/div[2]/div[3]/a"));
            }
        }
         public IWebElement ErrorMessageForInvalidEmail
        {
            get
            {
                return this.Driver.FindElement(By.XPath("/html/body/div[5]/h2"));
            }
        }
        public IWebElement ErrorMessageForShortPassword
        {
            get
            {
                return this.Driver.FindElement(By.XPath("/html/body/div[5]/h2"));
            }
        }
    }
}
