using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebDriverAdvanced.Pages.SortablePage
{
    public static class SortablePageAsserter
    {
        public static void AssertSortablePage(this SortablePage page)
        {
            Assert.IsTrue(page.SortableItem1.Location.Y < page.SortableItem3.Location.Y);
        }
        public static void AssertSortablePageConnectList(this SortablePage page)
        {
       
        }
        public static void AssertSortableDisplayAsGrid(this SortablePage page, string firstLiValue)
        {
           Assert.AreEqual(firstLiValue, page.FirstBox.Text);
          
        }
    }
}
