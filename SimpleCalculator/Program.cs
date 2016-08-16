using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Expression test = new Expression();
            test.CheckIfUserInputIsValid("3-1b2");
            test.CheckIfUserInputIsValid("11b2");
            test.CheckIfUserInputIsValid("100-12");
            test.CheckIfUserInputIsValid("");
            test.CheckIfUserInputIsValid("  3-12");
            test.CheckIfUserInputIsValid("3- 12   ");
            Console.ReadKey();
        }
    }
}
