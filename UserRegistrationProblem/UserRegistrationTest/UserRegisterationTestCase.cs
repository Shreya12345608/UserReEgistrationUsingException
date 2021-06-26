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
            string firstNameTest = userRegistration.ValidateFirstName("Shreya");
            string lastNameTest = userRegistration.ValidateFirstName("Malviya");
            string validateEmail = userRegistration.ValidateEmail("malviyashreya26@gmail.com");
            string validateMobileNo = userRegistration.ValidateMobileNo("8209685692");
            string validatePassword = userRegistration.ValidatePassword("Shreya158");
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
            string result = userRegistration.ValidateEmail(email);
            Assert.AreEqual("Happy", result);
        }
        [Test]
        public void Given_Empty_FirstName_Should_Throw_UserRegistrationException_Indicating_EmptyInput()
        {
            try
            {
                //Represents the empty string. This field is read-only.
                string name = string.Empty;
                UserRegistration userRegistration = new UserRegistration();
                string result = userRegistration.ValidateFirstName(name);
            }// If it gets to this line, no exception was thrown
            catch (UserRegistrationCustomException e)
            { // not the right kind of exception
              //assertion is a boolean expression at a specific point in a program 
                Assert.AreEqual("Name should not be empty", e.Message);
            }
        }
        [Test]
        public void Given_NULL_FirstName_Should_Throw_UserRegistrationException()
        {
            try
            {
                string name = null;
                UserRegistration userRegistration = new UserRegistration();
                string result = userRegistration.ValidateFirstName(name);
            }
            catch (UserRegistrationCustomException e)
            { // not the right kind of exception
              //assertion is a boolean expression at a specific point in a program 
                Assert.AreEqual("Name should not be null", e.Message);
            }
        }
        [Test]
        public void Given_Empty_LastName_Should_Throw_UserRegistrationException_Indicating_EmptyInput()
        {
            try
            {
                string name = string.Empty;
                UserRegistration userRegistration = new UserRegistration();
                string result = userRegistration.ValidateFirstName(name);
            }
            catch (UserRegistrationCustomException e)
            { // not the right kind of exception
              //assertion is a boolean expression at a specific point in a program 
                Assert.AreEqual("Name should not be empty", e.Message);
            }
        }
        [Test]
        public void Given_NULL_LastName_Should_Throw_UserRegistrationException()
        {
            try
            {
                string name = null;
                UserRegistration userRegistration = new UserRegistration();
                string result = userRegistration.ValidateFirstName(name);
            }
            catch (UserRegistrationCustomException e)
            { // not the right kind of exception
              //assertion is a boolean expression at a specific point in a program 
                Assert.AreEqual("Name should not be null", e.Message);
            }
        }
        [Test]
        public void Given_Empty_Email_Should_Throw_UserRegistrationException_Indicating_EmptyInput()
        {
            try
            {
                string email = string.Empty;
                UserRegistration userRegistration = new UserRegistration();
                string result = userRegistration.ValidateEmail(email);
            }
            catch (UserRegistrationCustomException e)
            { // not the right kind of exception
              //assertion is a boolean expression at a specific point in a program 
                Assert.AreEqual("Email should not be empty", e.Message);
            }
        }
        //Email 
        [Test]
        public void Given_NULL_Email_Should_Throw_UserRegistrationException()
        {
            try
            {
                string email = null;
                UserRegistration userRegistration = new UserRegistration();
                string result = userRegistration.ValidateEmail(email);
            }
            catch (UserRegistrationCustomException e)
            { // not the right kind of exception
              //assertion is a boolean expression at a specific point in a program 
                Assert.AreEqual("Email should not be null", e.Message);
            }
        }
        [Test]
        public void Given_Empty_Mobile_Should_Throw_UserRegistrationException_Indicating_EmptyInput()
        {
            try
            {
                string mobile = string.Empty;
                UserRegistration userRegistration = new UserRegistration();
                string result = userRegistration.ValidateMobileNo(mobile);
            }
            catch (UserRegistrationCustomException e)
            { // not the right kind of exception
              //assertion is a boolean expression at a specific point in a program 
                Assert.AreEqual("Mobile Number should not be empty", e.Message);
            }
        }
        [Test]
        public void Given_NULL_Mobile_Should_Throw_UserRegistrationException()
        {
            try
            {
                string mobile = null;
                UserRegistration userRegistration = new UserRegistration();
                string result = userRegistration.ValidateMobileNo(mobile);
            }
            catch (UserRegistrationCustomException e)
            { // not the right kind of exception
              //assertion is a boolean expression at a specific point in a program 
                Assert.AreEqual("Mobile Number should not be null", e.Message);
            }
        }
        [Test]
        public void Given_Empty_Password_Should_Throw_UserRegistrationException_Indicating_EmptyInput()
        {
            try
            {
                string password = string.Empty;
                UserRegistration userRegistration = new UserRegistration();
                string result = userRegistration.ValidatePassword(password);
            }
            catch (UserRegistrationCustomException e)
            { // not the right kind of exception
              //assertion is a boolean expression at a specific point in a program 
                Assert.AreEqual("Password should not be empty", e.Message);
            }
        }
        [Test]
        public void Given_NULL_Password_Should_Throw_UserRegistrationException()
        {
            try
            {
                string password = null;
                UserRegistration userRegistration = new UserRegistration();
                string result = userRegistration.ValidatePassword(password);
            }
            catch (UserRegistrationCustomException e)
            { // not the right kind of exception
              //assertion is a boolean expression at a specific point in a program 
                Assert.AreEqual("Password should not be null", e.Message);
            }
        }


    }
}
