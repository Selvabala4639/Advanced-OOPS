using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Multiple1
{
    public interface IFamilyInfo : IShowData
    {
        //FatherName, MotherName, HouseAddress, No.Of.Siblings  
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string HouseAddress { get; set; }
        public int Siblings { get; set; }

        
        
        //Method: ShowInfo
        void ShowInfo()
        {
            Console.WriteLine($"Fathername: {FatherName}");
            Console.WriteLine($"MotherName: {MotherName}");
            Console.WriteLine($"HouseAddress: {HouseAddress}");
            Console.WriteLine($"Siblings: {Siblings}");
        }
    }
}