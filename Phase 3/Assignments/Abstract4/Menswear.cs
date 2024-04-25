using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstract4
{
    public class Menswear: Dress
    {
        public override string DressType { get; set; }
        public  override string DressName { get; set; }
        public override double Price { get; set; }
        public override double TotalPrice { get; set; }

        public override void GetDressInfo(string type, string name, double price, double total)
        {
            DressType = type;
            DressName = name;
            Price = price;
            TotalPrice = total;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Dress Name : {DressName}");
            Console.WriteLine($"DressType : {DressType}");
            Console.WriteLine($"Dress Price : {Price}");
            Console.WriteLine($"Dress TotalPrice : {TotalPrice}");
            
        }
    }
}