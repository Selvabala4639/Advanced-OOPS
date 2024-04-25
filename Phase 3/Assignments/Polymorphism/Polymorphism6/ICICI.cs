using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polymorphism6
{
    public class ICICI :Bank
    {
        public override double GetIntresetInfo(double amount)
        {
            return amount*7.5 /100;
        }
    }
}