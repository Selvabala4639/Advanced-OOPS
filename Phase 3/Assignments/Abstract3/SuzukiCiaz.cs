using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstract3
{
    public class SuzukiCiaz : Car
    {
         public override void GetEngineType(string types)
        {
            CarType = types;
        }
        public override void GetNoOfSeats(int seats)
        {
            NoofSeats = seats;
        }
        public override void GetPrice(double price)
        {
            Price  = price;
        }
        public SuzukiCiaz(){}
         public override void ShowCarDetails()
         {
            Console.WriteLine($"Car Name: SuzukiCiaz");
            Console.WriteLine($"Cartype : {CarType}");
             Console.WriteLine($"NoofSeats : {NoofSeats}");
              Console.WriteLine($"Price : {Price}");
            
            
         }
    }
}