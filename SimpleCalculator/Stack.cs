using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Stack
    {
        public string LastAnswer { get; private set; }
        public string LastExpression { get; private set; }

        public void SetLastAnswer(string numString)
        {
            LastAnswer = numString;
        }

        public void SetLastExpression(int v1, int v2, char op)
        {
            LastExpression = string.Format("{0} {1} {2}", v1, op, v2);
        }
    }
}
