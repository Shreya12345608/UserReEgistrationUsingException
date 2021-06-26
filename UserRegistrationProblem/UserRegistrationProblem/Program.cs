using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            UserRegistration validateUser = new UserRegistration();
            validateUser.ValidateFirstName("Shreya");
            validateUser.ValidateFirstName("Malviya");
            validateUser.ValidateEmail("malviyashreya26@gmail.com");
            validateUser.ValidateMobileNo(" 91 8798761833");
            validateUser.ValidatePassword("Shreya345");
            validateUser.ValidatePassword("Shreya345");
           //validateUser.ValidateNumericPassword("shreya@3345");
           // validateUser.ValidateSpecialcarPassword("shreya@3345");
           // validateUser.ValidateAllTypeEmail("malviyashreya26@gmail.com");
           // validateUser.ValidateAllTypeEmail("malviyashreya5526@gmail.com");
           // validateUser.ValidateAllTypeEmail("malviyashre+26@gmail.com");
           // validateUser.ValidateAllTypeEmail("sabc_2002@gmail.com");
            Console.ReadKey();
        }
    }
}
