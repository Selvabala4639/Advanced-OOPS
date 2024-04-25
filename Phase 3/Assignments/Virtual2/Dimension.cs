using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Virtual2
{
    public class Dimension
    {
        //Property: value1, value 2, Area
        public double Value1 { get; set; }
        public double Value2 { get; set; }
        public double Area { get; set; }

    //Methods: virtual calculate  -> value1* value2, displayarea
        public Dimension(double value1, double value2)
        {
            Value1 = value1;
            Value2=value2;
        }
        public Dimension(double area)
        {
            Area = area;
        }
        public virtual void calculate()
        {
            Area = Value1*Value2;
        }
        public virtual void DisplayArea()
        {
            Console.WriteLine($"Area: {Area}");
            
        }
    }
}