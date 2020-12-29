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
    }
}
