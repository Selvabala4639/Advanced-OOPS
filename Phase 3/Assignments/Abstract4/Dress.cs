using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstract4
{
    public abstract class Dress
    {
        public abstract string DressType { get; set; }
        public  abstract string DressName { get; set; }
        public abstract double Price { get; set; }
        public abstract double TotalPrice { get; set; }

        public abstract void GetDressInfo(string type, string name, double price, double total);
        public abstract void DisplayInfo();
    }
}