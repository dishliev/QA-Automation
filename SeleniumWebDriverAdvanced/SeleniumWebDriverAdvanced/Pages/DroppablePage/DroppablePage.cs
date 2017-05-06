using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebDriverAdvanced.Pages.DroppablePage
{
   public partial class DroppablePage : BasePage
    {
       public DroppablePage(IWebDriver driver) : base(driver)
       { 
       
       }
       public string URL
       {
           get
           {
               return base.url + "droppable/";
           }
       }
       public void NavigateTo()
       {
           this.Driver.Navigate().GoToUrl(this.URL);
       }
       public void DragAndDrop()
       {
    
           Actions builder = new Actions(this.Driver);
           var drag = builder.DragAndDrop(this.Source, this.Target);
           drag.Perform();
       }
       //асджасджсадфжасдфсаф
       public void DragAndDropPreventPropagation1()
       {       
           PreventPropagation.Click();

           Actions builder = new Actions(this.Driver);
           var drag = builder.DragAndDrop(this.Source1, this.TargetFirstSmallRectangle);
           drag.Perform();
       }
       public void DragAndDropPreventPropagation2()
       {   
           PreventPropagation.Click();

           Actions builder = new Actions(this.Driver);
           var drag = builder.DragAndDrop(this.Source1, this.TargetSecondSmalRectangle);
           drag.Perform();
       }
       public void DragAndDropDroppableAccept()
       {
           Accept.Click();

           Actions builder = new Actions(this.Driver);
           var drag = builder.DragAndDrop(this.DraggableAccept, this.DroppableAccept);
           drag.Perform();
       }
       

            public void DragAndDropShopingCart()
       {
           ShopingCartDemo.Click();

           Actions builder = new Actions(this.Driver);
           var drag = builder.DragAndDrop(this.LolcatShirt, this.ShopingCart);
           drag.Perform();
       }
    }
}
