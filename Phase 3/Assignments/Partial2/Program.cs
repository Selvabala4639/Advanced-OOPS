using System;
namespace Partial2;
class Program
{
    public static void Main(string[] args)
    {
        StudentInfo student = new StudentInfo("Selva",  "male",new DateTime(2001,11,22),"9024976614",80,87,78);
        student.CalculateTotal();
        student.CalculatePercentage();
        student.Display();
    }
}