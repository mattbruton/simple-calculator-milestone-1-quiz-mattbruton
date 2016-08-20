using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator.Operations
{
    public class Modulus : Operation
    {
        public override string Operate(int val1, int val2)
        {
            return (val1 % val2).ToString();
        }
    }
}
