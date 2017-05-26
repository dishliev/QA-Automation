using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diana_ltd.comTests.Pages.Login
{
   public static class LoginPageAsserter
    {
       public static void AssertErrorMessageEmail(this LoginPage page, string text)
       {
           Assert.AreEqual(text, page.ErrorMessageForInvalidEmail.Text);
       }
       public static void AssertErrorShortPassword(this LoginPage page, string text)
       {
           Assert.AreEqual(text, page.ErrorMessageForShortPassword.Text);
       }
    }
}
