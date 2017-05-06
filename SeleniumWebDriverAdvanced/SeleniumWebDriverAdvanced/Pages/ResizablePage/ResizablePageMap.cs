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
    }
}
