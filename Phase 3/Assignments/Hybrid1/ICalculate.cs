using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hybrid1
{
    public interface ICalculate 
    {
        public double ProjectMark { get; set; }

        public void CalculateUGTotal();
         public void CalculateUGPercentage();
        
    }
}