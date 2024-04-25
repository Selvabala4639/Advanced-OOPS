using System;
namespace Interface;
class Program
{
    public static void Main(string[] args)
    {
        Square number = new Square();  //class varialbe as object
        number.Number = 20;
        Console.WriteLine(number.Calculate());

        Circle circleNumber = new Circle();
        circleNumber.Number = 10;
        Console.WriteLine(circleNumber.Calculate());

    }
}