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
            Evaluator test = new Evaluator();
            test.EvaluateUserInput(2, 0, '/');
        }
    }
}
