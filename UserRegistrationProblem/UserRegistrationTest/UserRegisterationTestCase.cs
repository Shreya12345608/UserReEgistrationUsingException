using NUnit.Framework;
using UserRegistrationProblem;
namespace UserRegistrationTest
{
    public class Tests
    {
        [Test]
        public void GivenFields_WhenCheck_ShouldReturnValid()
        {
            UserRegistration userRegistration = new UserRegistration();
            string firstNameTest = userRegistration.validateFirstName("Shreya");
            string lastNameTest = userRegistration.validateFirstName("Malviya");
            string validateEmail = userRegistration.validateEmail("malviyashreya26@gmail.com");
            string validateMobileNo = userRegistration.validateMobileNo("8209685692");
            string validatePassword = userRegistration.validatePassword("Shreya158");
            Assert.AreEqual("Happy", firstNameTest);
            Assert.AreEqual("Happy", lastNameTest);
            Assert.AreEqual("Happy", validateEmail);
            Assert.AreEqual("Happy", validateMobileNo);
            Assert.AreEqual("Happy", validatePassword);
        }

        //UC11
       // Write JUnit Parameterised Test to validate multiple entry for the Email Address.
        [Test]
        [TestCase("ShreyaM@gmail.com")]
        [TestCase("abc.100@yahoo.com")]
        [TestCase("abc-100@abc.net")]
        [TestCase("abc.100@abc.com.au")]
        [TestCase("abc+100@gmail.com")]
        public void ValidateSampleEmail_Should_return_true(string email)
        {
            UserRegistration userRegistration = new UserRegistration();
           string result = userRegistration.validateEmail(email);
            Assert.AreEqual("Happy",result);
        }
    }
}