using System;
namespace CafeteriaCardManagement;
class Program{
    public static void Main(string[] args)
    {
        Operations operation = new Operations();
        operation.AddDefaultData();
        operation.MainMenu();
    }
}