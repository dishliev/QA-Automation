using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlagsAndIPs.Pages.FlagpediaPage
{
    public partial class FlagpediaPage : BasePage
    {
        public static string url2;
        public FlagpediaPage(IWebDriver driver) : base(driver)
        {

        }
        public string URL
        {
            get
            {
                return url;
            }
        }

        public void NavigateTo(string url2)
        {
            this.Driver.Navigate().GoToUrl(this.URL + url2);
        }

    }
}
