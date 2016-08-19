namespace SimpleCalculator
{
    public static class ErrorMessages
    {
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
            return "\nInvalid input.\nPlease enter one of the following:\n\nA valid expression: i.e. 2 + 2\n\nSet a constant: i.e. x = 2 (note, you can only set this once per constant)\n\n\"last\": Returns the last answer provided by calculator\n\n\"lastp\": Returns the last expression entered\n\n\"exit\" or \"quit\": exits program\n";
        }
    }
}
