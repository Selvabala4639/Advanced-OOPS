using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Multiple2
{
    public class Eco:Car, IBrand
    {
        private static int s_makingID =100;
        public string MakingID { get;  }
        public string BrandName { get; set; }
        public string EngineNumber  { get; set; }
        public string ChasisNumber  { get; set; }

        public Eco(string name, string engine, string chasis,string type, int seats, string color, double tank, double kms){
            FuelType = type;
            NumberOfKmDriven=kms;
            Seats= seats;
            BrandName = name;
            EngineNumber = engine;
            ChasisNumber = chasis;
            Color= color;
            TankCapacity= tank;
            MakingID = "MID"+(++s_makingID);
        }
        public void ShowDetails()
        {
            Console.WriteLine($"MakingID :{MakingID}");
            Console.WriteLine($"BrandName :{BrandName}");
            Console.WriteLine($"FuelType :{FuelType}");
            Console.WriteLine($"NumberOfKmDriven :{NumberOfKmDriven}");
            Console.WriteLine($"EngineNumber :{EngineNumber}");
            Console.WriteLine($"ChasisNumber :{ChasisNumber}");
            Console.WriteLine($"TankCapacity :{TankCapacity}");
        }
    }
}