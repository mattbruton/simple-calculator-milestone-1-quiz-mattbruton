using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public static class ErrorMessages
    {
        public static string InvalidInput()
        {
            return "Invalid input - ";
        }

        public static string DivideByZero()
        {
            return "You cannot divide by zero.";
        }

        public static string ConstantNotDefined()
        {
            return "Constant is not defined yet.";
        }

        public static string ConstantAlreadyHasValue()
        {
            return "That constant has already been assigned a value. Please select a different one.";
        }

        public static string InvalidFormat()
        {
            return "Please enter an integer, followed by an operator, and then another integer (ex. \"2 + 5\"";
        }
    }
}
