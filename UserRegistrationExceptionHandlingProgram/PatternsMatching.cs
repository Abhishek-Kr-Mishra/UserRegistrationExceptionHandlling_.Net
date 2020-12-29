﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationExceptionHandlingProgram
{
    public class PatternsMatching
    {
        public static string REGEX_firstName = "^[A-Z][a-zA-Z]{2,}";
        public bool ValidateFirstName(string fname)
        {
            if(fname == null)
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.NULL_MESSAGE, "Regex can't Validate null First Name");
            }
            return Regex.IsMatch(fname, REGEX_firstName);
        }
    }
}