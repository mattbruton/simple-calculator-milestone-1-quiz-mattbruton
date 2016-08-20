using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator.Operations
{
    public abstract class Operation
    {
        public virtual string Operate(int val1, int val2)
        {
            return "";
        }
    }
}
