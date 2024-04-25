using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public class CylinderVolume :CircleArea
    {
        private  double _height;
        public   double Height { get{return _height;}}
        internal   double Volume { get; set; }

        public CylinderVolume(double height,double radius):base(radius)
        {
            _height = height;
        }
        public void CalculateVolume()
        {
            Volume = Area*_height;
        }
    }
}