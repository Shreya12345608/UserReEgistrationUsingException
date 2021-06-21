using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    class UserRegistration
    {
        //For First NAme
        public void validateFirstName(string firstName)
        {
            string stringForFirstName = "^[A-Z][a-z]{3,}?";
            try
            {

                if (Regex.IsMatch(firstName, stringForFirstName))
                    Console.WriteLine(firstName + " is Valid");

                else
                    Console.WriteLine(firstName + " is Invalid");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        //For last NAme
        public void validateLastName(string lastName)
        {
            string stringForLastName = "^[A-Z][a-z]{3,}?";
            try
            {


                if (Regex.IsMatch(lastName, stringForLastName))
                    Console.WriteLine(lastName + " is Valid");
                else
                    Console.WriteLine(lastName + " is Invalid");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        //For email
        public void validateEmailId(string emailID)
        {
            string stringForEmailId = "^[a-z0-9][-a-z0-9._]+@([-a-z0-9]+.)+[a-z]{2,5}$";
            try
            {

                if (Regex.IsMatch(emailID, stringForEmailId))
                    Console.WriteLine(emailID + " is Valid");
                else
                    Console.WriteLine(emailID + " is Invalid");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        //For Mobile Number
        public void validateMobileNumber(string mobileNumber)
        {
            string stringForMobileNumber = "^[0-9]{10}";
            try
            {


                if (Regex.IsMatch(mobileNumber, stringForMobileNumber))
                    Console.WriteLine(mobileNumber + " is Valid");
                else
                    Console.WriteLine(mobileNumber + " is Invalid");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        //For Password
        public void validatePassword(string password)
        {
            string stringForPassword = "^.{8,}?";
            try
            {
                if (Regex.IsMatch(password, stringForPassword))
                    Console.WriteLine(password + " is Valid");
                else
                    Console.WriteLine(password + " is Invalid");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        ////For Password
        public void validateUperCasePassword(string ucPassword)
        {
            string stringForUCPassword = "^[A-Z]+.{8,}?";
            try
            {
                if (Regex.IsMatch(ucPassword, stringForUCPassword))
                    Console.WriteLine(ucPassword + " is Valid");
                else
                    Console.WriteLine(ucPassword + " is Invalid");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        ////For Numeric Password
        public void validateNumericPassword(string NumericPassword)
        {
            string stringForNumericPassword = "^.{8,}?";
            try
            {

                if (Regex.IsMatch(NumericPassword, stringForNumericPassword))
                    Console.WriteLine(NumericPassword + " is Valid");
                else
                    Console.WriteLine(NumericPassword + " is Invalid");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        ////For Special  Password
        public void validateSpecialcarPassword(string specialCarPassword)
        {
            string stringForNumericPassword = "^([a-zA-Z0-9])*[!@#$%^&*]{1}([a-zA-Z0-9])*$";
            try
            {
                if (Regex.IsMatch(specialCarPassword, stringForNumericPassword))
                    Console.WriteLine(specialCarPassword + " is Valid");
                else
                    Console.WriteLine(specialCarPassword + " is Invalid");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}