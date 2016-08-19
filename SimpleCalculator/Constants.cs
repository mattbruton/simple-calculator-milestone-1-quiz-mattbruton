using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                if (ConstantList.ContainsKey(newConst))
                {
                    Console.WriteLine(ErrorMessages.ConstantAlreadyHasValue());
                }
                else
                {
                    AddConstantToDictionary(newConst, newValue);
                    Console.WriteLine("Success");
                }
                    return true;
            }
            else
            {
                return false;
            }
        }

        public void ParseNewConst(Match match)
        {
            newConst = match.Groups["Value1"].Value;
            newValue = Convert.ToInt32(match.Groups["Value2"].Value);
        }

        public void AddConstantToDictionary(string cons, int val)
        {
            ConstantList.Add(cons, val);
        }

        public bool CheckForExistingConstant()
        {
            return false;
        }
    }
}
