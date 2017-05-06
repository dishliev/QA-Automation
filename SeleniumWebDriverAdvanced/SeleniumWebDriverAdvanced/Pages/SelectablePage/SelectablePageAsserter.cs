using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebDriverAdvanced.Pages.SelectablePage
{
    public static class SelectablePageAsserter
    {
        public static void AssertTargetAttributeValueSelectableItem1(this SelectablePage page, string classValue)
        {
            Assert.AreEqual(classValue, page.Item1.GetAttribute("class"));
        }
        public static void AssertTargetAttributeValueSelectableItem2(this SelectablePage page, string classValue)
        {
            Assert.AreEqual(classValue, page.Item2.GetAttribute("class"));
        }
        public static void AssertTargetAttributeValueSelectableItem3(this SelectablePage page, string classValue)
        {
            Assert.AreEqual(classValue, page.Item3.GetAttribute("class"));
        }
        public static void AssertTargetAttributeValueNumberOne(this SelectablePage page, string classValue)
        {
            Assert.AreEqual(classValue, page.NumberOne.GetAttribute("class"));
        }
        public static void AssertTargetAttributeValueNumberNine(this SelectablePage page, string classValue)
        {
            Assert.AreEqual(classValue, page.NumberNine.GetAttribute("class"));
        }
        public static void AssertSelectResults(this SelectablePage page, string text)
        {
            Assert.AreEqual(page.SelectResults.Text, text);
        }
     
    }
}
