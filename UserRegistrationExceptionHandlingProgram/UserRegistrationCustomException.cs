using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistrationExceptionHandlingProgram
{
    public class UserRegistrationCustomException : Exception
    {
        public enum ExceptionType
        {
            NULL_MESSAGE,
        }
        public ExceptionType type;
        public UserRegistrationCustomException(ExceptionType Type, string message) : base(message)
        {
            this.type = Type;
        }
    }
}
