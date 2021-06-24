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
        static string Name = "^[A-Z][a-z0-9A-Z]{3,}";
        static string EmailId = "^[a-z0-9A-Z]+([._+-][a-z0-9A-Z]+)*[@][a-z0-9A-Z]+[.][a-zA-Z]{2,3}(.[a-zA-Z]{2,})?$";
        static string mobileNo = "[1-9]{1}[0-9]{9}";
        static string Password = "^(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#$%^&*()]){1}[a-zA-Z0-9]{5,}";
        public string validateFirstName(string name)
        {
            if (Regex.IsMatch(name, Name))
            {
                Console.WriteLine("Name is Valid");
                return "Happy";
            }
            else
            {
                Console.WriteLine("Name is Invalid");
                return "Sad";
            }
        }
        public string validateEmail(string email)
        {
            if (Regex.IsMatch(email, EmailId))
            {
                Console.WriteLine("Email ID is Valid");
                return "Happy";
            }
            else
            {
                Console.WriteLine("Email is Invalid");
                return "Sad";
            }
        }
            public string validateMobileNo(string mobileno)
            {
                if (Regex.IsMatch(mobileno, mobileNo))
                {
                    Console.WriteLine("Mobile No is Valid");
                    return "Happy";
                }
                else
                {
                    Console.WriteLine("Mobile No  is Invalid");
                    return "Sad";
                }
            }

        public string validatePassword(string Password)
        {
            if (Regex.IsMatch(Password, Password))
            {
                Console.WriteLine( "Password is Valid");
                return "Happy";
            }
            else
            {
                Console.WriteLine("Password is Invalid");
                return "Sad";
            }
        }
    }
}


