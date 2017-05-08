using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebDriverAdvanced.Pages.DraggablePage
{
    public static class DraggablePageAsserter
    {
        public static void AssertFirstTabSourceAttribute(this DraggablePage page, string text)
        {
            Assert.AreEqual(text, page.Box.GetAttribute("class"));
        }

        public static void AssertFirstBoxLocation(this DraggablePage page)
        {
            Assert.AreNotSame(page.FirstBoxConaitMovement.Location, page.SecondBoxConstrainMovement.Location);
        }
        
        public static void AssertSecondBoxSourceAttribute(this DraggablePage page, string text)
        {
            Assert.AreEqual(text, page.SecondBoxConstrainMovement.GetAttribute("class"));
        }

        public static void AssertEventsBoxDragInvokeCount(this DraggablePage page)
        {
            Assert.IsTrue(page.DragInvokeCountText.Text != "0");
        }
        
        public static void AssertBoxContainedInParentSourceAttribute(this DraggablePage page, string text)
        {
            Assert.AreEqual(text, page.BoxContainedInParent.GetAttribute("class"));
        }
        
        public static void AssertFirstBoxCursorStyleAttribute(this DraggablePage page, string style)
        {
            Assert.AreEqual(style, page.HtmlBody.GetAttribute("style"));
        }
    }
}
