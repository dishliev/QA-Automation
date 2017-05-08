using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebDriverAdvanced.Pages.ResizablePage
{
    public partial class ResizablePage
    {
        public IWebElement resizeButton
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"resizable\"]/div[3]"));
            }
        }

        public IWebElement resizeWindow
        {
            get
            {
                return this.Driver.FindElement(By.Id("resizable"));
            }
        }
        public IWebElement resizeButtonConstrainResizeArea
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"resizableconstrain\"]/div[3]"));
            }
        }
        public IWebElement ConstrainResizeArea
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"ui-id-3\"]"));
            }
        }
          public IWebElement resizableConstrainWindow
        {
            get
            {
                return this.Driver.FindElement(By.Id("resizableconstrain"));
            }
        }
          public IWebElement HelperBox
          {
              get
              {
                  return this.Driver.FindElement(By.XPath("//*[@id=\"resizable_helper\"]"));
              }
          }
         public IWebElement Helper
          {
              get
              {
                  return this.Driver.FindElement(By.XPath("//*[@id=\"ui-id-4\"]"));
              }
          }
         public IWebElement resizableButtonHelperBox
         {
             get
             {
                 return this.Driver.FindElement(By.XPath("//*[@id=\"resizable_helper\"]/div[3]"));
             }
         }
    }
}
