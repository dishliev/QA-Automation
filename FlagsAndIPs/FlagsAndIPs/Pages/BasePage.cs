using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlagsAndIPs.Pages
{
    public class BasePage
    {
        private IWebDriver driver;
        protected string url = @"http://flagpedia.net/";
        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebDriver Driver
        {
            get { return this.driver; }
        }

        public WebDriverWait Wait
        {
            get
            {
                WebDriverWait wait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(20));
                return wait;
            }
        }
    }
}