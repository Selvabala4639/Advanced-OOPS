using System;
namespace Polymorphism7;
class Program{
    public static void Main(string[] args)
    {
        Attendence month1 = new Attendence(25,3,2);
        //Console.WriteLine($"{month1.TotalSalary()}");
        Attendence month2 = new Attendence(26,3,2);
        //Console.WriteLine($"{month2.TotalSalary()}");
        Attendence month3 = new Attendence(20,3,2);
        //Console.WriteLine($"{month3.TotalSalary()}");
        Attendence total = Attendence.Add(month1,month2,month3);
        Console.WriteLine($"{total.TotalSalary()}");
        
    }
}