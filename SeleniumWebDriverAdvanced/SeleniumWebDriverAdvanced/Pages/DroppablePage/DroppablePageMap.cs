using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebDriverAdvanced.Pages.DroppablePage
{
    public partial class DroppablePage
    {
        public IWebElement Source
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"draggableview\"]/p"));
            }
        }

        public IWebElement Target
        {
            get
            {
                return this.Driver.FindElement(By.Id("droppableview"));
            }
        }

        //sadfvasdfvasdfasdfsdafv
        public IWebElement Source1
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"draggableprop\"]/p"));
            }
        }

        public IWebElement TargetFirstSmallRectangle
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"droppable-inner\"]"));
            }
        }

        public IWebElement PreventPropagation
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"ui-id-3\"]"));
            }
        }

        public IWebElement Accept
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"ui-id-2\"]"));
            }
        }
        public IWebElement ShopingCartDemo
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"ui-id-5\"]"));
            }
        }
        public IWebElement TargetSecondSmalRectangle
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"droppable2-inner\"]/p"));
            }
        }
        public IWebElement SecondBigRectangle
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"droppableprop2\"]"));
            }
        }
        public IWebElement SecondSmallRectangle
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"droppable2-inner\"]"));
            }
        }
        public IWebElement DraggableAccept
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"draggableaccept\"]/p"));
            }
        }
        public IWebElement DroppableAccept
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"droppableaccept\"]"));
            }
        }
        public IWebElement LolcatShirt
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"ui-id-7\"]/ul/li[1]"));
            }
        }
        public IWebElement ShopingCart
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"cart\"]/div/ol/li"));
            }
        }
     
    }
}
