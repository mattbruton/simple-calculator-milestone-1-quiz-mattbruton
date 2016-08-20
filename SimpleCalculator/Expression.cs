﻿using System;
using System.Text.RegularExpressions;

namespace SimpleCalculator
{
    public class Expression
    {
        Constants con = new Constants();
        Evaluator eval = new Evaluator();

        public int Value_1 { get; set; }
        public int Value_2 { get; set; }
        public char Operator { get; set; }

        public bool IsValidInput;
        public bool UsingConstInInput = false;

        private Regex regexPattern = new Regex(@"^(\s*(?<Value1>[-]?\d+)\s*(?<Operator>[+-/%*])\s*(?<Value2>[-]?\d+)\s*)$");
        public Regex constPattern = new Regex(@"^(\s*(?<Value1>[A-Za-z])\s*(?<Operator>[+-/%*])\s*(?<Value2>[-]?\d+)\s*)$");
        public Regex constPattern2 = new Regex(@"^(\s*(?<Value1>[-]?\d*)\s*(?<Operator>[+-/%*])\s*(?<Value2>[A-Za-z])\s*)$");

        public void CheckInputForStandardPattern(string input)
        {
            Match expressionMatch = regexPattern.Match(input);
            AssignUserValuesToProperties(expressionMatch);  
        }

        public bool CheckInputForConstPattern(string input)
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

        public bool CheckInputForConstPattern2(string input)
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