using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Constants
    {
        public Dictionary<string, int> ConstantList = new Dictionary<string, int>();
        
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
