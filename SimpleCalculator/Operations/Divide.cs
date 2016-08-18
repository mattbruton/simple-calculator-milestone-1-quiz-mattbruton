using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator.Operations
{
    public class Divide : Operation
    {
        public override string Operate(int val1, int val2)
        {
            if (val2 == 0)
            {
                return ErrorMessages.DivideByZero();
            }
            else
            {
                return (val1 / val2).ToString();
            }
        }
    }
}
