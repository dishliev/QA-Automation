using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebDriverAdvanced.Pages.ResizablePage
{
    public static class ResiblePageAsserter
    {
        public static void AssertNewSize(this ResizablePage page)
        {

            Assert.IsTrue(page.resizeWindow.Size.Width > 332 && page.resizeWindow.Size.Width < 335);
            Assert.IsTrue(page.resizeWindow.Size.Height > 332 && page.resizeWindow.Size.Height < 335);
       
        }
        public static void AssertNewSizeConstrain(this ResizablePage page)
        {

            Assert.IsTrue(page.resizableConstrainWindow.Size.Width < 183 && page.resizableConstrainWindow.Size.Width > 178);
            Assert.IsTrue(page.resizableConstrainWindow.Size.Height > 91 && page.resizableConstrainWindow.Size.Height < 95);

          
        }
        public static void AssertNewSizeHelperBox(this ResizablePage page)
        {
       
            Assert.IsTrue(page.HelperBox.Size.Width > 290 && page.HelperBox.Size.Width < 300);
            Assert.IsTrue(page.HelperBox.Size.Height > 290 && page.HelperBox.Size.Height < 300);


        }
    }
}
