using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polymorphism6
{
    public abstract class Bank
    {
        public Bank()
        {
            
        }
        public abstract double  GetIntresetInfo(double amount);
    }
}