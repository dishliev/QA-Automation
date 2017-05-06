using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebDriverAdvanced.Pages.DroppablePage
{
    public static class DroppablePageAsserter
    {
        public static void AssertTargetAttributeValue(this DroppablePage page, string classValue)
        {
            Assert.AreEqual(classValue, page.Target.GetAttribute("class"));
        }
        //sdfbasdfbasdfb
        public static void AssertTargetAttributeValueFirstSmallRectangle(this DroppablePage page, string classValue)
        {
            Assert.AreEqual(classValue, page.TargetFirstSmallRectangle.GetAttribute("class"));
        }
           public static void AssertTargetAttributeValueSecondBigRectangle(this DroppablePage page, string classValue)
        {
            Assert.AreEqual(classValue, page.SecondBigRectangle.GetAttribute("class"));
        }
           public static void AssertTargetAttributeValueSecondSmallRectangle(this DroppablePage page, string classValue)
           {
               Assert.AreEqual(classValue, page.SecondSmallRectangle.GetAttribute("class"));
           }
           public static void AssertTargetAttributeValueDroppableAccept(this DroppablePage page, string classValue)
           {
               Assert.AreEqual(classValue, page.DroppableAccept.GetAttribute("class"));
           }
           public static void AssertTargetAttributeValueShopingCartTshirt(this DroppablePage page, string text)
           {
               Assert.AreEqual(page.ShopingCart.Text, text);
           }
    }
}

