using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebDriverAdvanced.Pages.RegistrationPage
{
    public static class RegistrationPageAsserter
    {
        // PAGE IS OPEN
        public static void AssertRegistrationPageIsOpen(this RegistrationPage page, string text)
        {
            Assert.AreEqual(text, page.Header.Text);
        }
        // NAME
        public static void AssertNamesErrorMessage(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessagesForNames.Displayed);
            StringAssert.Contains(text, page.ErrorMessagesForNames.Text);
        }
        // INVALID EMAIL
        public static void AssertEmailErrorMessage(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessagesForEmail.Displayed);
            StringAssert.Contains(text, page.ErrorMessagesForEmail.Text);
        }
        // MISSING EMAIL
        public static void AssertEmailMissingErrorMessage(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessagesForMissingEmail.Displayed);
            StringAssert.Contains(text, page.ErrorMessagesForMissingEmail.Text);
        }
        // Upload FILE
        public static void AssertUploadFileErrorMessage(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessagesForUploadFile.Displayed);
            StringAssert.Contains(text, page.ErrorMessagesForUploadFile.Text);
        }
        // PHONE
        public static void AssertPhoneErrorMessage(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessagesForPhone.Displayed);
            StringAssert.Contains(text, page.ErrorMessagesForPhone.Text);
        }
        // PASSWORD
        public static void AssertPasswordErrorMessage(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessagesForPassword.Displayed);
            StringAssert.Contains(text, page.ErrorMessagesForPassword.Text);
        }
        // CONFIRM PASSWORD
        public static void AssertConfirmPasswordErrorMessage(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessagesForConfirmPassword.Displayed);
            StringAssert.Contains(text, page.ErrorMessagesForConfirmPassword.Text);
        }
        // PASSWORD MINIMUM CHARACTERS
        public static void AssertPasswordMinimumCharactersErrorMessage(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessagesForPasswordMinimumCharacters.Displayed);
            StringAssert.Contains(text, page.ErrorMessagesForPasswordMinimumCharacters.Text);
        }
        // PASSWORD FIELDS DO NOT MATCH
        public static void AssertPasswordFieldsDoNotMatchErrorMessage(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessagesForPasswordFieldsDoNotMatch.Displayed);
            StringAssert.Contains(text, page.ErrorMessagesForPasswordFieldsDoNotMatch.Text);
        }
        // HOBBY
        public static void AssertHobbyErrorMessage(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessagesForHobby.Displayed);
            StringAssert.Contains(text, page.ErrorMessagesForHobby.Text);
        }
        //  USERNAME ALREADY EXISTS
        public static void AssertUserNameAlreadyExsistErrorMessage(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessagesForUsernameAlreadyExsist.Displayed);
            StringAssert.Contains(text, page.ErrorMessagesForUsernameAlreadyExsist.Text);
        }
        //  MISSING USERNAME 
        public static void AssertMissingUserName(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessagesForMissingUsername.Displayed);
            StringAssert.Contains(text, page.ErrorMessagesForMissingUsername.Text);
        }
        // EMAIL ALREADY EXSIST
        public static void AssertEmailAlreadyExsist(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessagesEmailAlreadyExsist.Displayed);
            StringAssert.Contains(text, page.ErrorMessagesEmailAlreadyExsist.Text);
        }
    }
}
