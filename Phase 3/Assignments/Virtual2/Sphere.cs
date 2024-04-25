using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Virtual2
{
    public class Sphere : Dimension
    {
        public double Radius { get; set; }

        public Sphere(double radius, double area):base(area)
        {
            Radius= radius;
        }
        public override void calculate()
        {
            Area = Radius *Radius*4*3.14;
        }
        public override void DisplayArea()
        {
            base.DisplayArea();
        }
    }
}