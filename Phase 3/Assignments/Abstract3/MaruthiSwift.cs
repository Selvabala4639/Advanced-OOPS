using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstract3
{
    public class MaruthiSwift :Car
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
        public MaruthiSwift(){}
         public override void ShowCarDetails()
         {
            Console.WriteLine($"Car Name: MaruthiSwift");
            Console.WriteLine($"Cartype : {CarType}");
             Console.WriteLine($"NoofSeats : {NoofSeats}");
              Console.WriteLine($"Price : {Price}");
            
            
         }
    }
}