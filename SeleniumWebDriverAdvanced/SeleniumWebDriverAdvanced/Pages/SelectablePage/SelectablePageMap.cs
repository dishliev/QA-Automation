using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebDriverAdvanced.Pages.SelectablePage
{
    public partial class SelectablePage
    {
        public IWebElement Item1
        {
            get
            {
            return this.Driver.FindElement(By.XPath("//*[@id=\"selectable\"]/li[1]"));
            }
         
        }
        public IWebElement Item2
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"selectable\"]/li[2]"));
            }

        }
        public IWebElement Item3
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"selectable\"]/li[3]"));
            }

        }
        public IWebElement DisplayAsGrid
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"ui-id-2\"]"));
            }

        }
        public IWebElement Seriazile
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"ui-id-3\"]"));
            }

        }
        public IWebElement NumberOne
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"selectable_grid\"]/li[1]"));
            }

        }
        public IWebElement NumberNine
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"selectable_grid\"]/li[9]"));
            }

        }
        public IWebElement SerizableItem1
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"selectable-serialize\"]/li[1]"));
            }

        }
        public IWebElement SerizableItem3
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"selectable-serialize\"]/li[3]"));
            }

        }
        public IWebElement SerizableItem5
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"selectable-serialize\"]/li[5]"));
            }

        }
        public IWebElement SelectResults
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"select-result\"]"));
            }

        }
    }
}
