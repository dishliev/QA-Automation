using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diana_ltd.comTests.Pages.ContactForm
{
    public static class ContactFormPageAsserter
    {
        public static void AssertErrorMessageForEmail(this ContactFormPage page, string text)
        {
            Assert.AreEqual(text, page.ErrorMessageEmail.Text);

        }
        public static void AssertMessageForSuccessSend(this ContactFormPage page, string text)
        {
            Assert.AreEqual(text, page.MessageSuccessSend.Text);

        }
    }
}
