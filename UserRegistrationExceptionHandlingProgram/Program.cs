using System;

namespace UserRegistrationExceptionHandlingProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To User Registration Exception Handling");
            PatternsMatching patterns = new PatternsMatching();

            if (patterns.ValidateFirstName(null)) { Console.WriteLine("Valid First Name"); }
            else { Console.WriteLine("Invalid First Name"); }

            if (patterns.ValidateLastName(null)) { Console.WriteLine("Valid Last Name"); }
            else { Console.WriteLine("Invalid Last Name"); }

            if (patterns.ValidateEmail(null)) { Console.WriteLine("Valid Email ID"); }
            else { Console.WriteLine("Invalid Email ID"); }
            if (patterns.ValidatePhoneNumber(null)) { Console.WriteLine("Valid Phone Number"); }
            else { Console.WriteLine("Invalid Phone Number"); }
        }
    }
}
