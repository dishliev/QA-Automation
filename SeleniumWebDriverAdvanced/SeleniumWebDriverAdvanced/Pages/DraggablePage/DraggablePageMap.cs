using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebDriverAdvanced.Pages.DraggablePage
{
   public partial class DraggablePage
   {
       public IWebElement Box
       {
           get
           {
               return this.Driver.FindElement(By.XPath("//*[@id=\"draggable\"]"));
           }
       }

       public IWebElement FirstBoxConaitMovement
       {
           get
           {
               return this.Driver.FindElement(By.XPath("//*[@id=\"draggabl\"]"));
           }
       }
       public IWebElement SecondBoxConstrainMovement
       {
           get
           {
               return this.Driver.FindElement(By.XPath("//*[@id=\"draggabl2\"]"));
           }
       }
       
     
       public IWebElement ConstrainMovement
       {
           get
           {
               return this.Driver.FindElement(By.XPath("//*[@id=\"ui-id-2\"]"));
           }                                        
       }
       public IWebElement EventsBox
       {
           get
           {
               return this.Driver.FindElement(By.XPath("//*[@id=\"dragevent\"]"));
           }
       }
       public IWebElement Events
       {
           get
           {
               return this.Driver.FindElement(By.XPath("//*[@id=\"ui-id-4\"]"));
           }
       }
       public IWebElement DragInvokeCountText
       {
           get
           {
               return this.Driver.FindElement(By.XPath("//*[@id=\"event-drag\"]/span[2]"));
           }
       }
       public IWebElement BoxContainedInParent
       {
           get
           {
               return this.Driver.FindElement(By.XPath("//*[@id=\"draggabl5\"]"));
           }
       }

   }
}
