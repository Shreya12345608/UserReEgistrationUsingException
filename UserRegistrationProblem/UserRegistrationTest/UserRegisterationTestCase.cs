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
            string validatePassword = userRegistration.validatePassword("Shreya@158");
            Assert.AreEqual("Valid", firstNameTest);
            Assert.AreEqual("Valid", lastNameTest);
            Assert.AreEqual("Valid", validateEmail);
            Assert.AreEqual("Valid", validateMobileNo);
            Assert.AreEqual("Valid", validatePassword);
        }
    }
}