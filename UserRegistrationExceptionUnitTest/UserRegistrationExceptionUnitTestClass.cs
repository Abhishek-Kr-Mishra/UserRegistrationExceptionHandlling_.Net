using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationExceptionHandlingProgram;

namespace UserRegistrationExceptionUnitTest
{
    [TestClass]
    public class UserRegistrationExceptionUnitTestClass
    {
        readonly PatternsMatching patternsMatching = new PatternsMatching();
        [TestMethod]
        public void GivenNullFirstName_ShouldThrow_UserRegistrationCustomException()
        {
            try
            {
                bool expectedValue = true;
                Assert.AreEqual(expectedValue, patternsMatching.ValidateFirstName(null));
            }
            catch(UserRegistrationCustomException e)
            {
                Assert.AreEqual("Regex can't Validate null First Name", e.Message);
            }
        }
        [TestMethod]
        public void GivenNullLastName_ShouldThrow_UserRegistrationCustomException()
        {
            try
            {
                bool expectedValue = true;
                Assert.AreEqual(expectedValue, patternsMatching.ValidateLastName(null));
            }
            catch (UserRegistrationCustomException e)
            {
                Assert.AreEqual("Regex can't Validate null Last Name", e.Message);
            }
        }
        [TestMethod]
        public void GivenNullEmailID_ShouldThrow_UserRegistrationCustomException()
        {
            try
            {
                bool expectedValue = true;
                Assert.AreEqual(expectedValue, patternsMatching.ValidateEmail(null));
            }
            catch (UserRegistrationCustomException e)
            {
                Assert.AreEqual("Regex can't Validate null Email ID", e.Message);
            }
        }
        [TestMethod]
        public void GivenNullPhoneNumber_ShouldThrow_UserRegistrationCustomException()
        {
            try
            {
                bool expectedValue = true;
                Assert.AreEqual(expectedValue, patternsMatching.ValidatePhoneNumber(null));
            }
            catch (UserRegistrationCustomException e)
            {
                Assert.AreEqual("Regex can't Validate null Phone Number", e.Message);
            }
        }
        [TestMethod]
        public void GivenNullPassword_ShouldThrow_UserRegistrationCustomException()
        {
            try
            {
                bool expectedValue = true;
                Assert.AreEqual(expectedValue, patternsMatching.ValidatePassword(null));
            }
            catch (UserRegistrationCustomException e)
            {
                Assert.AreEqual("Regex can't Validate null Password", e.Message);
            }
        }
    }
}
