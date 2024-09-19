using polymorphism;
using System;
using System.Collections.Generic;

namespace Polymorphism
{
   
    class Program
    {
        static void Main(string[] args)
        {
            // 7. Create a list of UserErrors and populate with instances of NumericInputError and TextInputError
            List<UserError> userErrors = new List<UserError>
            {
                new NumericInputError(),
                new TextInputError(),
                new NullInputError(),       // Custom error
                new EmptyInputError(),      // Custom error
                new SpecialCharacterError() // Custom error
            };

            // 8. Print all UserError messages using a foreach loop
            foreach (UserError error in userErrors)
            {
                Console.WriteLine(error.UEMessage());
            }
        }
    }
}
