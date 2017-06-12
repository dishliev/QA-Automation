using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlagsAndIPs.Pages.ContentPage
{
    public partial class ContentPage
    {
        public IWebElement CountryName
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"content\"]/dl[1]/dd[2]"));
            }
        }

        public IWebElement CapitalName
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"content\"]/dl[1]/dd[3]"));
            }
        }
        public IWebElement Code
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"content\"]/dl[1]/dd[10]"));
            }
        }
       
    }
}
