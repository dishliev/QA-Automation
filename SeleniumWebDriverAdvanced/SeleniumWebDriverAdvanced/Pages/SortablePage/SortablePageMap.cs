using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebDriverAdvanced.Pages.SortablePage
{
    public partial class SortablePage
    {
        public IWebElement SortableItem1 
        
        {
            get 
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"sortable\"]/li[1]"));
            }
        }

        public IWebElement SortableItem3 
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"sortable\"]/li[3]"));
            }
        }
        public IWebElement ConnectListFirstBoxItem1
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"sortable1\"]/li[1]"));
            }
        }
        public IWebElement ConnectListFirstBoxItem5
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"sortable1\"]/li[4]"));
            }
        }
        public IWebElement ConnectList
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"ui-id-2\"]"));
            }
        }
        public IWebElement ConnectListSecondBox
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"sortable2\"]"));
            }
        }
        public IWebElement ConnectListFirstBoxItem3
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"sortable1\"]/li[2]"));
            }
        }
        public IWebElement ConnectListSecondBoxItem2
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"sortable2\"]/li[2]"));
            }
        }
        public IWebElement DisplayAsGridOne
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"sortable_grid\"]/li[1]"));
            }
        }
        public IWebElement DisplayAsGridSix
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"sortable_grid\"]/li[6]"));
            }
        }
        public IWebElement DisplayAsGrid
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"ui-id-3\"]"));
            }
        }
        public IWebElement FirstBox
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"sortable_grid\"]/li[1]"));
            }
        }
    }
}


