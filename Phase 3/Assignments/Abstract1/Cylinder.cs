using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstract1
{
    public class Cylinder : Shape
    {
        public override double Volume { get; set; }
        public override double Area { get; set; }
        public Cylinder(double radius , double height)
        {
            Radius = radius;
            Height= height;
        }

        public override void CalculateArea()
        {
            Area = 2*3.14*(Radius+Height)*Radius;
        }

        public override void CalculateVolume()
        {
            Volume = 3.14 * Radius*Radius*Height;
        }

    }
}