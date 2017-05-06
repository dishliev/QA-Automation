using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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

            // DROPPABLE TESTS
            [Test]
            [Property("DragAndDrop", 3)]
            public void DroppableTestOne()
            {
              
                var droppablePage = new DroppablePage(this.driver);

                droppablePage.NavigateTo();
                droppablePage.DragAndDrop();

                droppablePage.AssertTargetAttributeValue("ui-widget-header ui-droppable ui-state-highlight");

            }

            [Test]
            [Property("DragAndDrop", 3)]
            public void DroppableTestTwo()
            {

                var droppablePage = new DroppablePage(this.driver);

                droppablePage.NavigateTo();
                droppablePage.DragAndDropDroppableAccept();
          

                droppablePage.AssertTargetAttributeValueDroppableAccept("ui-widget-header ui-droppable ui-state-highlight");

            }

            [Test]
            [Property("DragAndDrop", 3)]
            public void DroppableTestTree()
            {
               
                var droppablePage = new DroppablePage(this.driver);

                droppablePage.NavigateTo();
                droppablePage.DragAndDropPreventPropagation1();

                droppablePage.AssertTargetAttributeValueFirstSmallRectangle("ui-widget-header ui-droppable ui-state-highlight");

            }

            [Test]
            [Property("DragAndDrop", 3)]
            public void DroppableTestFour()
            {

                var droppablePage = new DroppablePage(this.driver);

                droppablePage.NavigateTo();
                droppablePage.DragAndDropPreventPropagation2();

                droppablePage.AssertTargetAttributeValueSecondBigRectangle("ui-widget-header ui-droppable");
                droppablePage.AssertTargetAttributeValueSecondSmallRectangle("ui-widget-header ui-droppable ui-state-highlight");

            }
            [Test]
            [Property("DragAndDrop", 3)]
            public void DroppableTestFive()
            {

                var droppablePage = new DroppablePage(this.driver);

                droppablePage.NavigateTo();
                droppablePage.DragAndDropShopingCart();

                droppablePage.AssertTargetAttributeValueShopingCartTshirt("Lolcat Shirt");
             

            }

           //SELECTABLE TESTS
            [Test]
            [Property("Selectable", 2)]
            public void SelectableTestOne()
            {
                var selectablePage = new SelectablePage(this.driver);

                selectablePage.NavigateTo();
                selectablePage.SelectableItem1();

                selectablePage.AssertTargetAttributeValueSelectableItem1("ui-widget-content ui-corner-left ui-selectee ui-selected");
            }
            [Test]
            [Property("Selectable", 2)]
            public void SelectableTestTwo()
            {
                var selectablePage = new SelectablePage(this.driver);

                selectablePage.NavigateTo();
                selectablePage.SelectableItem1AndItem2AndItem3();

                selectablePage.AssertTargetAttributeValueSelectableItem1("ui-widget-content ui-corner-left ui-selectee ui-selected");
                selectablePage.AssertTargetAttributeValueSelectableItem2("ui-widget-content ui-corner-left ui-selectee ui-selected");
                selectablePage.AssertTargetAttributeValueSelectableItem3("ui-widget-content ui-corner-left ui-selectee ui-selected");
            }

            [Test]
            [Property("Selectable", 2)]
            public void SelectableTestTree()
            {
                var selectablePage = new SelectablePage(this.driver);

                selectablePage.NavigateTo();
                selectablePage.SelectableNumberOneAndNumberNine();

                selectablePage.AssertTargetAttributeValueNumberOne("ui-state-default ui-corner-left ui-selectee ui-selected");
                selectablePage.AssertTargetAttributeValueNumberNine("ui-state-default ui-corner-left ui-selectee ui-selected");

               
            }
            [Test]
            [Property("Selectable", 2)]
            public void SelectableTestFour()
            {
                var selectablePage = new SelectablePage(this.driver);

                selectablePage.NavigateTo();
                selectablePage.SelectableSeriazile();

                selectablePage.AssertSelectResults("#1#3#5");


            }
            //SORTABLE TESTS


           [Test]
           [Property("ToolsQA", 3)]
            public void SortableOne() 
           
           {
               var sortablePage = new SortablePage(this.driver);
               
               sortablePage.NavigateTo();
               sortablePage.Sortable();

               sortablePage.AssertSortablePage();

           
           }
           [Test]
           [Property("ToolsQA", 3)]
           public void SortableTwo()
           {
               var sortablePage = new SortablePage(this.driver);

               sortablePage.NavigateTo();



               sortablePage.SortableConnectList();

               sortablePage.AssertSortablePageConnectList();


           }
           [Test]
           [Property("ToolsQA", 3)]
           public void SortableTree()
           {
               var sortablePage = new SortablePage(this.driver);

               sortablePage.NavigateTo();



               sortablePage.DisplayAsGrid1();

               sortablePage.AssertSortableDisplayAsGrid("2");


           }






            // RESIZABLE TESTS


            [Test]
            [Property("ToolsQA", 3)]
            public void ResizeFirstTry()
            {
             
                var resizblePage = new ResizablePage(this.driver);

                resizblePage.IncreaseWidthAndheightBy(100);

                resizblePage.AssertNewSize(100, 100);
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

            }
        }
    }
}

