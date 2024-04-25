using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Threading.Tasks;
using MathsLib;

namespace CalculatorApp
{
    public class CircleArea :Maths
    {
        protected internal double _radius;
        public  double Radius { get{return _radius;}  }
        internal  double Area { get; set; }
        
        public CircleArea(double radius)
        {
            _radius = GetValue(radius);
        }
        public double CalculateCircleArea()
        {
            Area =PI*_radius*_radius;
            return Area;
        }
        private double GetValue(double radius)
        {
            return radius;
        }
    }
}