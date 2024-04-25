using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstract1
{
    public class Cube :Shape
    {
         public override double Volume { get; set; }
        public override double Area { get; set; }
        public Cube(double page_A)
        {
            Page_A = page_A;
        }

        public override void CalculateArea()
        {
            Area = 6*Page_A*Page_A;
        }

        public override void CalculateVolume()
        {
            Volume = Page_A*Page_A*Page_A;
        }
    }
}