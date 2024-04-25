using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstract3
{
    public abstract class Car
    {
        private static int s_noOfWheels =4;
        public int NoOfWheels { get{return s_noOfWheels;} }
         private static int s_noOfDoors =4;
         public int NoOfDoors { get{return s_noOfDoors;} }
         public string EngineType { get; set; }
         public int NoofSeats { get; set; }
         public string CarType { get; set; }
         public double Price { get; set; }
         

         public void ShowWheels()
         {
            Console.WriteLine($"NoOfWheels :{NoOfWheels}");
            
         }
         public void ShowDoors()
         {
             Console.WriteLine($"NoOfDoors :{NoOfDoors}");
         }

        public abstract void GetEngineType(string type);
        public abstract void GetNoOfSeats(int seats);
        public abstract void GetPrice(double price);
         public abstract void ShowCarDetails();
    }
}