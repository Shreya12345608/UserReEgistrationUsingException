using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    /// <summary>
    /// Regex Validations User Registration Custom exceptions class derived from Exception class
    /// </summary>
    public class UserRegistrationCustomException : Exception
    {
        /// <summary>
        /// Contains types of Exceptions that can occur during user validations. 
        /// </summary>
        public enum ExceptionType
        {
            NULL_INPUT,
            EMPTY_INPUT
        }
        ////Creating 'type' variable of type ExceptionType
        private readonly ExceptionType type;
        /// <summary>
        /// Parameterized Constructor sets the Exception Type and message.
        /// </summary>
        /// <param name="Type"></param>
        /// <param name="message"></param>
        public UserRegistrationCustomException(ExceptionType Type, String message) : base(message)
        {
            this.type = Type;
        }
    }
    }