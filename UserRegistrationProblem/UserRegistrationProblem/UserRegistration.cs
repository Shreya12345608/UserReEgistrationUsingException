using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    public class UserRegistration
    {
        readonly string Name = "^[A-Z][a-z0-9A-Z]{3,}";
        readonly string EmailId = "^[a-z0-9A-Z]+([._+-][a-z0-9A-Z]+)*[@][a-z0-9A-Z]+[.][a-zA-Z]{2,3}(.[a-zA-Z]{2,})?$";
        readonly string mobileNo = "[0-9]{1,3}[ ][1-9]{1}[0-9]{9}";
        readonly string Password = "^(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#$%^&*()]){1}[a-zA-Z0-9]{5,}";

        public string ValidateFirstName(string name)
        {
            try
            {
                if (name.Equals(string.Empty))
                {
                    throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.EMPTY_INPUT, "Name should not be empty");
                }

                else if (Regex.IsMatch(name, Name))
                {
                    Console.WriteLine("Valid name");
                    return "Happy";
                }
                else
                {
                    Console.WriteLine("Invalid name");
                    return "Sad";
                }
            }
            catch (NullReferenceException)
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.NULL_INPUT, "Name should not be null");
            }

        }
        public string ValidateEmail(string email)
        {
            try
            {
                if (email.Equals(string.Empty))
                {
                    throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.EMPTY_INPUT, "Email should not be empty");
                }
                else if (Regex.IsMatch(email, EmailId))
                {
                    Console.WriteLine("Valid email");
                    return "Happy";
                }
                else
                {
                    Console.WriteLine("invalid email");
                    return "Sad";
                }
            }
            catch (NullReferenceException)
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.NULL_INPUT, "Email should not be null");
            }
        }
        public string ValidateMobileNo(string mobile)
        {
            try
            {
                if (mobile.Equals(string.Empty))
                {
                    throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.EMPTY_INPUT, "Mobile Number should not be empty");
                }
                else if (Regex.IsMatch(mobile, mobileNo))
                {
                    Console.WriteLine("mobile number is valid");
                    return "Happy";
                }
                else
                {
                    Console.WriteLine("mobile number not valid");
                    return "Sad";
                }
            }
            catch (NullReferenceException)
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.NULL_INPUT, "Mobile Number should not be null");
            }
        }
        public string ValidatePassword(string password)
        {
            try
            {
                if (password.Equals(string.Empty))
                {
                    throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.EMPTY_INPUT, "Password should not be empty");
                }
                else if (Regex.IsMatch(password, Password))
                {
                    Console.WriteLine("Valid password");
                    return "Happy";
                }
                else
                {
                    Console.WriteLine("Invalid password");
                    return "Sad";
                }
            }
            catch (NullReferenceException)
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.NULL_INPUT, "Password should not be null");
            }

        }
    }
}


