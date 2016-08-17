using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Evaluator
    {
        public int ResultFromEval { get; private set; }

        public void EvaluateUserInput(int v1, int v2, char op)
        {
            switch (op)
            {
                case '+':
                    ResultFromEval = v1 + v2;
                    break;
                case '-':
                    ResultFromEval = v1 - v2;
                    break;
                case '/':
                    ResultFromEval = v1 / v2;
                    break;
                case '*':
                    ResultFromEval = v1 * v2;
                    break;
                case '%':
                    try
                    {
                        ResultFromEval = v1 % v2;
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("You can't divide by zero.");
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
