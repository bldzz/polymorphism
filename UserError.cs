using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    // 1. Abstract class UserError
    public abstract class UserError
    {
        // 2. Abstract method UEMessage with return type string
        public abstract string UEMessage();
    }

    // 3. NumericInputError class inherits from UserError
    public class NumericInputError : UserError
    {
        // 4. Override UEMessage method to return a specific error message
        public override string UEMessage()
        {
            return "You tried to use a numeric input in a text only field. This fired an error!";
        }
    }

    // 5. TextInputError class inherits from UserError
    public class TextInputError : UserError
    {
        // 6. Override UEMessage method to return a specific error message
        public override string UEMessage()
        {
            return "You tried to use a text input in a numeric only field. This fired an error!";
        }
    }

    // 9. Creating three custom UserError classes with unique UEMessage implementations

    // First custom error class
    public class NullInputError : UserError
    {
        public override string UEMessage()
        {
            return "You attempted to input a null value. This fired an error!";
        }
    }

    // Second custom error class
    public class EmptyInputError : UserError
    {
        public override string UEMessage()
        {
            return "You attempted to submit an empty input. This fired an error!";
        }
    }

    // Third custom error class
    public class SpecialCharacterError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use special characters in a restricted field. This fired an error!";
        }
    }

}
