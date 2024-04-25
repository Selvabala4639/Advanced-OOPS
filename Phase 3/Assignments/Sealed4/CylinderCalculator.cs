using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sealed4
{
    public class CylinderCalculator : Calculator
    {
        public double Area { get; set; }
         public double Volume { get; set; }

         public override void Area()   //Sealed class can't be overridden
         {
            
         }
    }
}