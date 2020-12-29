using System;

namespace UserRegistrationExceptionHandlingProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To User Registration Exception Handling");
            PatternsMatching patterns = new PatternsMatching();
            //Console.WriteLine(patterns.ValidateFirstName(null));

            if (patterns.ValidateFirstName(null)) { Console.WriteLine("Valid First Name"); }
            else { Console.WriteLine("Invalid First Name"); }
        }
    }
}
