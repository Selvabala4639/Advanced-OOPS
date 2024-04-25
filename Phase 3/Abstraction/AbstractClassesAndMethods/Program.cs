using System;
namespace AbstractClassesAndMethods;
class Program
{
    public static void Main(string[] args)
    {
        Syncfusion job1 = new Syncfusion();
        job1.Name = "Selva";
        Console.WriteLine($"{job1.Display()}");
        Console.WriteLine(job1.Salary(30));
    }
}