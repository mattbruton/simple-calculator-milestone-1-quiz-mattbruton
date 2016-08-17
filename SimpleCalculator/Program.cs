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
            Expression testExp = new Expression();
            Evaluator test = new Evaluator();

            testExp.CheckIfUserInputIsValid("5/2");
            if (testExp.IsValidInput)
            {
                test.EvaluateUserInput(testExp.Value_1, testExp.Value_2, testExp.Operator);
                Console.WriteLine("You entered: {0} {1} {2} ", testExp.Value_1, testExp.Operator, testExp.Value_2);
                Console.WriteLine(test.ResultFromEval);
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }

            Console.ReadKey();
        }
    }
}
