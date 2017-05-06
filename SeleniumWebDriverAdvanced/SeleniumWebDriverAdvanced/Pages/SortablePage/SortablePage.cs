using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebDriverAdvanced.Pages.SortablePage
{
    public partial class SortablePage : BasePage
    {
         public SortablePage(IWebDriver driver) : base(driver)
       { 
       
       }
       public string URL
       {
           get
           {
               return base.url + "sortable/";
           }
       }
       public void NavigateTo()
       {
           this.Driver.Navigate().GoToUrl(this.URL);
       }

       public void Sortable ()
       {
           Actions builder = new Actions(this.Driver);

           var sortable = builder.DragAndDropToOffset(SortableItem1,1,100).Release();
           sortable.Perform();
       }
         public void SortableConnectList ()
       {
           Actions builder = new Actions(this.Driver);
           ConnectList.Click();

           var sortable = builder.DragAndDrop(ConnectListFirstBoxItem1, ConnectListSecondBox).Release().DragAndDrop(ConnectListFirstBoxItem3, ConnectListSecondBox).Release();

           sortable.Perform();

            var sortable1 = builder.DragAndDrop()
       }
         public void DisplayAsGrid1()
         {
             Actions builder = new Actions(this.Driver);
             DisplayAsGrid.Click();

             var sortable = builder.DragAndDropToOffset(DisplayAsGridOne, 0, 100).Release();
             sortable.Perform();
         }
    }
}

