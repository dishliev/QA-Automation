using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebDriverAdvanced.Pages.DraggablePage
{
   public partial class DraggablePage : BasePage
    {
       public DraggablePage(IWebDriver driver)
           : base(driver)
       { 
       
       }
       public string URL
       {
           get
           {
               return base.url + "draggable/";
           }
       }
       public void NavigateTo()
       {
           this.Driver.Navigate().GoToUrl(this.URL);
       }
         public void DragFirstBox()
        {
            var builder = new Actions(this.Driver);

            var drag = builder.ClickAndHold(Box).MoveByOffset(30, 40);

            drag.Perform();
        }

        public void DragVerticalFirstBox()
        {
            ConstrainMovement.Click();
            var builder = new Actions(this.Driver);
       

            var drag = builder.ClickAndHold(FirstBoxConaitMovement).MoveByOffset(0, 30);

            drag.Perform();
        }

        public void DragHorizontalSecondBox()
        {
            ConstrainMovement.Click();
            var builder = new Actions(this.Driver);


            var drag = builder.ClickAndHold(SecondBoxConstrainMovement).MoveByOffset(30, 0);

            drag.Perform();
        }

        public void DragEventsBox()
        {
            Events.Click();
            var builder = new Actions(this.Driver);

            var drag = builder.ClickAndHold(EventsBox).MoveByOffset(50, 60);

            drag.Perform();


        }
        public void DragBoxContainedInParent()
        {
            ConstrainMovement.Click();
            var builder = new Actions(this.Driver);

            var drag = builder.ClickAndHold(BoxContainedInParent).MoveByOffset(0, 20);
            drag.Perform();
        }
    }
}


