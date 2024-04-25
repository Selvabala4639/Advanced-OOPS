using System;
namespace Polymorphism4;
class Program{
    public static void Main(string[] args)
    {
        FreeLancer free = new FreeLancer("selva", "vel","male","SDE");
        free.CalculateSalary(20);
        free.DisplayInfo();

        Syncfusion sync = new Syncfusion(free.Name,free.FatherName,free.Gender,free.Role,"SF46739","Chennai");
        sync.CalculateSalary(30);
        sync.DisplayInfo();
    }
}