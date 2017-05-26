using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diana_ltd.comTests.Pages.SearchByBrand
{
    public partial class SearchByBrand
    {
        public IWebElement CarBrandDropDown
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"CarBrand\"]"));
            }
        }
        public IWebElement CarModelDropDown
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"CarModel\"]"));
            }
        }
        public IWebElement CarEngineDropDown
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"CarVersion\"]"));
            }
        }
        public IWebElement CarYearDropDown
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"CarYear\"]"));
            }
        }
        public IWebElement ButtonShowResult
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"tab-2\"]/div/a"));
            }
        }
    }
}
