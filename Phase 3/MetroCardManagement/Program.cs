using System;
namespace MetroCardManagement;
class Program
{
    public static void Main(string[] args)
    {
        FileHandling.Create();
        FileHandling.ReadFromCSV();
        //Operations.AddDefaultData();
        Operations.MainMenu();
        FileHandling.WriteToCSV();
        
        // CustomList<int> elementList = new CustomList<int>();
        // elementList.Add(10);
        // elementList.Add(20);
        // foreach(int element in elementList)
        // {
        //     Console.WriteLine($"{element}");
        // }
    }
}