using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationExceptionHandlingProgram
{
    public class PatternsMatching
    {
        public static string REGEX_firstName = "^[A-Z][a-zA-Z]{2,}";
        public static string REGEX_lastName = "^[A-Z][a-zA-Z]{2,}";
        public static string REGEX_EMAIL = @"^[A-Za-z0-9]+([.\-_][a-zA-Z0-9]+)*@[a-zA-Z0-9]+[.][a-zA-Z]{2,4}([\.][a-zA-Z]{2}){0,1}$";
        public static string REGEX_PhoneNumber = "^[+]91[6-9]{1}[0-9]{9}$";
        public static string REGEX_PASSWORD = "^(?=.{8,}$)(?=.*?[0-9])(?=.*[A-Z])[a-zA-Z0-9]*[#!@$^&-][a-zA-Z0-9]*$";
        public bool ValidateFirstName(string fname)
        {
            if(fname == null)
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.NULL_MESSAGE, "Regex can't Validate null First Name");
            }
            return Regex.IsMatch(fname, REGEX_firstName);
        }
        public bool ValidateLastName(string lname)
        {
            if (lname == null)
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.NULL_MESSAGE, "Regex can't Validate null Last Name");
            }
            return Regex.IsMatch(lname, REGEX_lastName);
        }
        public bool ValidateEmail(string email)
        {
            if (email == null)
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.NULL_MESSAGE, "Regex can't Validate null Email ID");
            }
            return Regex.IsMatch(email, REGEX_EMAIL);
        }
        public bool ValidatePhoneNumber(string phoneNumber)
        {
            if (phoneNumber == null)
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.NULL_MESSAGE, "Regex can't Validate null Phone Number");
            }
            return Regex.IsMatch(phoneNumber, REGEX_PhoneNumber);
        }
        public bool ValidatePassword(string password)
        {
            if(password == null)
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.NULL_MESSAGE, "Regex can't Validate null Password");
            }
            return Regex.IsMatch(password, REGEX_PASSWORD);
        }
    }
}
