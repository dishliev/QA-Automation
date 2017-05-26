using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diana_ltd.comTests.Pages.SearchByBrand
{
    public partial class SearchByBrand : BasePage 
    {
        public SearchByBrand(IWebDriver driver)
            : base(driver)
        {
        }

        public string URL
        {
            get
            {
                return url;
            }
        }

        public void NavigateTo()
        {
            this.Driver.Navigate().GoToUrl(this.URL);
        }
    }
}
