using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumWebDriverAdvanced.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebDriverAdvanced.Pages.SelectablePage
{
    public partial class SelectablePage : BasePage
    {
        public SelectablePage(IWebDriver driver) : base(driver)
        {
        }
        public string URL
        {
            get
            {
                return base.url + "selectable/";
            }
        }
           public void NavigateTo()
       {
           this.Driver.Navigate().GoToUrl(this.URL);
       }
           public void SelectableItem1()
           {
               var builder = new Actions(this.Driver);

               var select = builder.Click(Item1);

               select.Perform();
           }
           public void SelectableItem1AndItem2AndItem3()
           {
               var builder = new Actions(this.Driver);

               var select = builder.ClickAndHold(Item1).ClickAndHold(Item2).ClickAndHold(Item3).Release();

               select.Perform();
           }
           public void SelectableNumberOneAndNumberNine()
           {
               var builder = new Actions(this.Driver);
               DisplayAsGrid.Click();

               var select = builder.MoveToElement(NumberOne).Click();
               select.Perform();
               builder.KeyDown(Keys.Control);
          
               var select2 = builder.MoveToElement(NumberNine).Click();
               select2.Perform();
              
           }
           public void SelectableSeriazile()
           { // builder no work good
               var builder = new Actions(this.Driver);
               Seriazile.Click();

               builder.KeyDown(Keys.Control);

               var select1 = builder.MoveToElement(SerizableItem1).Click();
               select1.Perform();

               builder.KeyDown(Keys.Control);
             
               var select2 = builder.MoveToElement(SerizableItem3).Click();
               select2.Perform();

      
               var select3 = builder.MoveToElement(SerizableItem5).Click();
               select3.Perform();

           }
    }
}

