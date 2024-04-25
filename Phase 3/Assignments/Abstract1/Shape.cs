using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstract1
{
    public abstract class Shape
    {
        public abstract double Volume { get; set; }
        public abstract double Area { get; set; }

        public  double Page_A { get; set; }

        //Radius, Height, Width
        public double Radius { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }

        //CalculateArea, CalculateVolume
        public abstract void CalculateArea();
        public abstract void CalculateVolume();
    }
}