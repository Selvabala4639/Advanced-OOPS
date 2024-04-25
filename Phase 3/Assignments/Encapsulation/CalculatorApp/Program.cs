using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public class Program
    {
        CircleArea circle = new CircleArea(4.0);
        double result = circle.CalculateCircleArea();  //A field initializer cannot reference the non-static field, method, or property 'Program.circle'
        CylinderVolume cylinder = new CylinderVolume(20,4);
        cylinder.CalculateVolume(); 
        
    }
}