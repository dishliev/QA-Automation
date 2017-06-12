using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlagsAndIPs.Pages.NavigationPage
{
   public partial class NavigationPage
    {
        public IWebElement AllCountry
        {
            get
            {                                           
                return this.Driver.FindElement(By.XPath("//*[@id=\"leftmenu-style\"]/ul[2]/li[1]"));

            }
        }
    }
}
