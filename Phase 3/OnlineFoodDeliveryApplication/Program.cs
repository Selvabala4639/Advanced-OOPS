using System;
namespace OnlineFoodDeliveryApplication;
class Program
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