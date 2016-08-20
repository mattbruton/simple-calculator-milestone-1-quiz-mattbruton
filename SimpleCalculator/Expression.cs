using System;
using System.Text.RegularExpressions;

namespace SimpleCalculator
{
    public class Expression
    {
        public int Value_1 { get; private set; }
        public int Value_2 { get; private set; }
        public char Operator { get; private set; }

        public bool IsValidInput;
        public bool UsingConstInInput = false;

        private Regex regexPattern = new Regex(@"^(\s*(?<Value1>[-]?\d+)\s*(?<Operator>[+-/%*])\s*(?<Value2>[-]?\d+)\s*)$");
        private Regex constPattern = new Regex(@"^(\s*(?<Value1>[A-Za-z])\s*(?<Operator>[+-/%*])\s*(?<Value2>[-]?\d+)\s*)$");
        private Regex constPattern2 = new Regex(@"^(\s*(?<Value1>[-]?\d*)\s*(?<Operator>[+-/%*])\s*(?<Value2>[A-Za-z])\s*)$");

        public void CheckInputForStandardPattern(string input)
        {
            Match expressionMatch = regexPattern.Match(input);
            AssignUserValuesToProperties(expressionMatch);  
        }

        private bool CheckInputForConstPattern(string input)
        {
            Match constMatch = constPattern.Match(input);
            if (constMatch.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool CheckInputForConstPattern2(string input)
        {
            Match constMatch = constPattern2.Match(input);
            if (constMatch.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ConvertConstToInt(string input)
        {
            if (CheckInputForConstPattern(input))
            {

            }
            else if (CheckInputForConstPattern2(input))
            {

            }
            else
            {
                CheckInputForStandardPattern(input);
            }

        }

        public void CheckIfUserInputIsValid(string input)
        {
            try
            {   
                CheckInputForStandardPattern(input);
                IsValidInput = true;
            }
            catch (FormatException)
            {
                IsValidInput = false;
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