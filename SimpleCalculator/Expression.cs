using System;
using System.Text.RegularExpressions;

namespace SimpleCalculator
{
    public class Expression
    {
        public int Value_1 { get; private set; }
        public int Value_2 { get; private set; }
        public char Operator { get; private set; }

        private Regex regexPattern = new Regex(@"^(\s*(?<Value1>\d+)\s*(?<Operator>[+-/%*]{1})\s*(?<Value2>\d+)\s*)$");

        public void CheckInputForPattern(string input)
        {
            Match expressionMatch = regexPattern.Match(input);
            AssignUserValuesToProperties(expressionMatch);  
        }
        
        public void CheckIfUserInputIsValid(string input)
        {
            try
            {
                CheckInputForPattern(input);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input.");
            }
        }

        private void AssignUserValuesToProperties(Match match)
        {
            Value_1 = Convert.ToInt32(match.Groups["Value1"].Value);
            Value_2 = Convert.ToInt32(match.Groups["Value2"].Value);
            Operator = Convert.ToChar(match.Groups["Operator"].Value);
        }
    }
}