using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedicineStore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FileHandling.Create();
            FileHandling.ReadFromCSV();
            //Operations.AddDefaultData();
            Operations.MainMenu();
            FileHandling.WriteToCSV();
        }
    }
}