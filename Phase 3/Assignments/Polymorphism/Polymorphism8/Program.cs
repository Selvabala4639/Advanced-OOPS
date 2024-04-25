using System;
namespace Polymorphism8;
class Program{
    public static void Main(string[] args)
    {
        Calculator sem1 = new Calculator(67,58,65,45,45,56);
        Calculator sem2 = new Calculator(67,58,65,45,45,56);
        Calculator sem3 = new Calculator(67,58,65,45,45,56);
        Calculator sem4 = new Calculator(67,58,65,45,45,56);
        Calculator totalSems = Calculator.Add(sem1,sem2,sem3,sem4);
        Console.WriteLine($"Total Marks: {totalSems.TotalMark()}");
        Console.WriteLine($"Percentage: {totalSems.CalculatePercentage()}");
        
        

    }
}