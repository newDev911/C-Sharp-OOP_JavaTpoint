using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP_JavaTpoint.Exception_Handling
{
    public class UserDefinedExceptionExample
    {
        // :2
        public void validate(int age)
        {
            if(age < 18)
            {
                throw new InvalidAgeException("Sorry! You must be 18+");
            }
        }

        // OR
        public void validate_WithTryCatch(int age)
        {
            try
            {
                validate(age);
            }
            catch(InvalidAgeException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            Console.WriteLine("\n\nRest of the code...");
        }
    }

    // :1
    // USER-DEFINED EXCEPTION:
    // To do this we need to inherit "Exception" class
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException(String message) : base(message)
        {

        }
    }

    
}
