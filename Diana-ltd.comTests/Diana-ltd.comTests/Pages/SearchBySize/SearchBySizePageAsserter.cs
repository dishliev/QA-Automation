using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diana_ltd.comTests.Pages.SearchBySize
{
    public static class SearchBySizePageAsserter
    {
        public static void AssertTyreSizeSearchResult(this SearchBySizePage page, string text)
        {
            Assert.AreEqual(text, page.TyreSizeResult.Text);
        }
        public static void AssertRunflatSearchResult(this SearchBySizePage page)
        {
            Assert.IsTrue(page.RunflatAndXLSearchResult.Text.Contains("RFT"));
        }
        public static void AssertXLSearchResult(this SearchBySizePage page)
        {
            Assert.IsTrue(page.RunflatAndXLSearchResult.Text.Contains("XL"));
        }
    }
}
