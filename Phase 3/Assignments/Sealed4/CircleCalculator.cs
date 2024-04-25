using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sealed4
{
    public double Area { get; set; }
    public class CircleCalculator : CalCulator
    {
        public sealed override void Area(double radius)
        {
            Area = 3.14*radius*radius;
        }
    }
}