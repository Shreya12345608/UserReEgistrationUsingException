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
            validateUser.validateFirstName("Shreya");
            validateUser.validateLastName("Malviya");
            validateUser.validateEmailId("malviyashreya26@gmail.com");
            Console.ReadKey();
        }
    }
}
