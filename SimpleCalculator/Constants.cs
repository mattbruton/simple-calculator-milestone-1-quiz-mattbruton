using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SimpleCalculator
{
    public class Constants
    {
        private string newConst;
        private int newValue;

        public Dictionary<string, int> ConstantList = new Dictionary<string, int>();

        private Regex constPattern = new Regex(@"^(\s*(?<Value1>[A-Za-z])\s*[=]\s*(?<Value2>[-]?\d+)\s*)$");

        public bool IsInputANewConst(string input)
        {
            Match constMatch = constPattern.Match(input);
            if (constMatch.Success)
            {
                ParseNewConst(constMatch);
                if (ConstantList.ContainsKey(newConst.ToLower()))
                {
                    Console.WriteLine(ErrorMessages.ConstantAlreadyHasValue());
                }
                else
                {
                    AddConstantToDictionary(newConst, newValue);
                    Console.WriteLine(ConstantAddedMessage(newConst.ToLower(), newValue.ToString()));
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        private string ConstantAddedMessage(string cons, string val)
        {
            return string.Format("'{0}' saved as '{1}'", cons, val);
        }

        private void ParseNewConst(Match match)
        {
            newConst = match.Groups["Value1"].Value;
            newValue = Convert.ToInt32(match.Groups["Value2"].Value);
        }

        private void AddConstantToDictionary(string cons, int val)
        {
            ConstantList.Add(cons.ToLower(), val);
        }
    }
}
