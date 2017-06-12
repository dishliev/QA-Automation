using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlagsAndIPs.Pages.TargetPage
{
    public partial class TargetPage
    {
        public List<IWebElement> NamesAllCountry
        {
            get
            {
                var reminder = this.Driver.FindElement(By.XPath("//*[@id=\"content\"]/div[2]"));

                //("//*[@id=\"content\"]/div[2]/div[2]/ul[1]"));
                //(By.XPath("//*[@id=\"content\"]/div[2]"));
                List<IWebElement> list = reminder.FindElements(By.TagName("li")).ToList();
                return list;

            }
        }
    }
}
