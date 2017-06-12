using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlagsAndIPs.Pages.FlagpediaPage
{
    public partial class FlagpediaPage
    {
        public IWebElement CountryMap
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"map\"]")));
                return this.Driver.FindElement(By.XPath("//*[@id=\"map\"]"));

            }
        }
    }
}
