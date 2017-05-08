using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumWebDriverAdvanced.Pages.DraggablePage;
using SeleniumWebDriverAdvanced.Pages.DroppablePage;
using SeleniumWebDriverAdvanced.Pages.ResizablePage;
using SeleniumWebDriverAdvanced.Pages.SelectablePage;
using SeleniumWebDriverAdvanced.Pages.SortablePage;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebDriverAdvanced
{
    public class AdvancedTests
    {
        [TestFixture]
        public class DemoQATests
        {
            public IWebDriver driver;

            [SetUp]
            public void Init()
            {
                this.driver = new ChromeDriver();
            }

            // DRAGGABLE TESTS
            [Test, Property("Draggable", 3)]
            [Author("Kiril Dishliev")]
           
            public void DraggableTestOne()
            {
                var draggablePage = new DraggablePage(driver);

                draggablePage.NavigateTo();
                draggablePage.DragFirstBox();
                                                                          
                draggablePage.AssertFirstTabSourceAttribute("ui-widget-content ui-draggable ui-draggable-handle ui-draggable-dragging");
            }

            [Test, Property("Draggable", 3)]
            [Author("Kiril Dishliev")]
          
            public void DraggableTestTwo()
            {
                var draggablePage = new DraggablePage(driver);

                draggablePage.NavigateTo();
                draggablePage.DragVerticalFirstBox();

                draggablePage.AssertFirstBoxLocation();
            }

            [Test, Property("Draggable", 3)]
            [Author("Kiril Dishliev")]
         
            public void DraggableTestThree()
            {
                var draggablePage = new DraggablePage(driver);

                draggablePage.NavigateTo();
                draggablePage.DragHorizontalSecondBox();

                draggablePage.AssertSecondBoxSourceAttribute("draggable ui-widget-content ui-draggable ui-draggable-handle ui-draggable-dragging");
            }

            [Test, Property("Draggable", 3)]
            [Author("Kiril Dishliev")]
            
            public void DraggableTestFour()
            {
                var draggablePage = new DraggablePage(this.driver);

                draggablePage.NavigateTo();
                draggablePage.DragEventsBox();

                draggablePage.AssertEventsBoxDragInvokeCount();
                
       
            }

            [Test, Property("Draggable", 3)]
            [Author("Kiril Dishliev")]
          
            public void DraggableTestFive()
            {
                var draggablePage = new DraggablePage(this.driver);

                draggablePage.NavigateTo();
                draggablePage.DragBoxContainedInParent();

                draggablePage.AssertBoxContainedInParentSourceAttribute("ui-widget-header ui-draggable ui-draggable-handle ui-draggable-dragging");
            }

    
            // DROPPABLE TESTS
            [Test, Property("Droppable", 3)]
            [Author("Kiril Dishliev")]
            public void DroppableTestOne()
            {
              
                var droppablePage = new DroppablePage(this.driver);

                droppablePage.NavigateTo();
                droppablePage.DragAndDrop();

                droppablePage.AssertTargetAttributeValue("ui-widget-header ui-droppable ui-state-highlight");

            }

            [Test, Property("Droppable", 3)]
            [Author("Kiril Dishliev")]
            public void DroppableTestTwo()
            {

                var droppablePage = new DroppablePage(this.driver);

                droppablePage.NavigateTo();
                droppablePage.DragAndDropDroppableAccept();
          

                droppablePage.AssertTargetAttributeValueDroppableAccept("ui-widget-header ui-droppable ui-state-highlight");

            }

            [Test, Property("Droppable", 3)]
            [Author("Kiril Dishliev")]
            public void DroppableTestThree()
            {
               
                var droppablePage = new DroppablePage(this.driver);

                droppablePage.NavigateTo();
                droppablePage.DragAndDropPreventPropagation1();

                droppablePage.AssertTargetAttributeValueFirstSmallRectangle("ui-widget-header ui-droppable ui-state-highlight");

            }

            [Test, Property("Droppable", 3)]
            [Author("Kiril Dishliev")]
            public void DroppableTestFour()
            {

                var droppablePage = new DroppablePage(this.driver);

                droppablePage.NavigateTo();
                droppablePage.DragAndDropPreventPropagation2();

                droppablePage.AssertTargetAttributeValueSecondBigRectangle("ui-widget-header ui-droppable");
                droppablePage.AssertTargetAttributeValueSecondSmallRectangle("ui-widget-header ui-droppable ui-state-highlight");

            }
            [Test, Property("Droppable", 3)]
            [Author("Kiril Dishliev")]
            public void DroppableTestFive()
            {

                var droppablePage = new DroppablePage(this.driver);

                droppablePage.NavigateTo();
                droppablePage.DragAndDropShopingCart();

                droppablePage.AssertTargetAttributeValueShopingCartTshirt("Lolcat Shirt");
             

            }

           //SELECTABLE TESTS
            
            [Test, Property("Selectable", 3)]
            [Author("Kiril Dishliev")]
            public void SelectableTestOne()
            {
                var selectablePage = new SelectablePage(this.driver);

                selectablePage.NavigateTo();
                selectablePage.SelectableItem1();

                selectablePage.AssertTargetAttributeValueSelectableItem1("ui-widget-content ui-corner-left ui-selectee ui-selected");
            }
            [Test, Property("Selectable", 3)]
            [Author("Kiril Dishliev")]
            public void SelectableTestTwo()
            {
                var selectablePage = new SelectablePage(this.driver);

                selectablePage.NavigateTo();
                selectablePage.SelectableItem1AndItem2AndItem3();

                selectablePage.AssertTargetAttributeValueSelectableItem1("ui-widget-content ui-corner-left ui-selectee ui-selected");
                selectablePage.AssertTargetAttributeValueSelectableItem2("ui-widget-content ui-corner-left ui-selectee ui-selected");
                selectablePage.AssertTargetAttributeValueSelectableItem3("ui-widget-content ui-corner-left ui-selectee ui-selected");
            }

            [Test, Property("Selectable", 3)]
            [Author("Kiril Dishliev")]
            public void SelectableTestThree()
            {
                var selectablePage = new SelectablePage(this.driver);

                selectablePage.NavigateTo();
                selectablePage.SelectableNumberOneAndNumberNine();

                selectablePage.AssertTargetAttributeValueNumberOne("ui-state-default ui-corner-left ui-selectee ui-selected");
                selectablePage.AssertTargetAttributeValueNumberNine("ui-state-default ui-corner-left ui-selectee ui-selected");

               
            }
            [Test, Property("Selectable", 3)]
            [Author("Kiril Dishliev")]
            public void SelectableTestFour()
            {
                var selectablePage = new SelectablePage(this.driver);

                selectablePage.NavigateTo();
                selectablePage.SelectableSeriazile();

                selectablePage.AssertSelectResults("#1#3#5");


            }
            
            //SORTABLE TESTS


            [Test, Property("Sortable", 3)]
            [Author("Kiril Dishliev")]
            public void SortableOne() 
           
           {
               var sortablePage = new SortablePage(this.driver);
               
               sortablePage.NavigateTo();
               sortablePage.Sortable();

               sortablePage.AssertSortablePage();

           
           }
           [Test, Property("Sortable", 3)]
           [Author("Kiril Dishliev")]
           public void SortableTwo()
           {
               var sortablePage = new SortablePage(this.driver);

               sortablePage.NavigateTo();

               sortablePage.SortableConnectList();

               sortablePage.AssertSortablePageConnectList("Item 1");


           }
           [Test, Property("Sortable", 3)]
           [Author("Kiril Dishliev")]
           public void SortableThree()
           {
               var sortablePage = new SortablePage(this.driver);

               sortablePage.NavigateTo();

               sortablePage.DisplayAsGrid1();

               sortablePage.AssertSortableDisplayAsGrid("2");


           }

            // RESIZABLE TESTS
            
           [Test, Property("Resizable", 3)]
           [Author("Kiril Dishliev")]
            public void ResizeTestOne()
            {
             
                var resizblePage = new ResizablePage(this.driver);

                resizblePage.IncreaseWidthAndheightBy(200);

                resizblePage.AssertNewSize();
            }

            [Test, Property("Resizable", 3)]
            [Author("Kiril Dishliev")]
            public void ResizeTestTwo()
            {

                var resizblePage = new ResizablePage(this.driver);

                resizblePage.IncreaseWidthAndHeightConstrain(100, 50);

                resizblePage.AssertNewSizeConstrain();
            }
            [Test, Property("Resizable", 3)]
            [Author("Kiril Dishliev")]
            public void ResizeTestThree()
            {

                var resizblePage = new ResizablePage(this.driver);

                resizblePage.IncreaseWidthAndHeightHelperBox(100, 100);

                resizblePage.AssertNewSizeHelperBox();
            }


            [TearDown]
            public void CleanUp()
            {
                if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                {
                    string filename = ConfigurationManager.AppSettings["Logs"] + TestContext.CurrentContext.Test.Name + ".txt";
                    if (File.Exists(filename))
                    {
                        File.Delete(filename);
                    }
                    File.WriteAllText(filename, TestContext.CurrentContext.Test.FullName + "        " + TestContext.CurrentContext.WorkDirectory + "            " + TestContext.CurrentContext.Result.PassCount);

                    var screenshot = ((ITakesScreenshot)this.driver).GetScreenshot();
                    screenshot.SaveAsFile(filename + TestContext.CurrentContext.Test.Name + ".jpg", ScreenshotImageFormat.Jpeg);
                }

                driver.Quit();
            }
        }
    }
}

