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
            return "Please enter an expression to evaluate, 'last' to see the last answer, 'lastp' to see the last entered command or expression, or type either 'quit' or 'exit' to end the application.";
        }
    }
}
