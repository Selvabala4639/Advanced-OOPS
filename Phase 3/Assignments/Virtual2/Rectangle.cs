using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Virtual2
{
    public class Rectangle : Dimension
    {
        //Property: Length, height
        public double Length { get; set; }
        public double Height { get; set; }

        public Rectangle(double length, double height, double area):base( area)
        {
            Length = length;
            Height = height;
        }
        //Methods: overriden calculate -> use base class calculate method – Length* Height , displayarea
        
        public override void calculate()
        {
            Area = Length*Height;
        }
        public override void DisplayArea()
        {
            base.DisplayArea();
        }
    }
}