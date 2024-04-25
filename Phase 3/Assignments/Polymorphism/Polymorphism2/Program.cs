using System;
namespace Polymorphism2;
class Program{
    public static void Main(string[] args)
    {
        square1(5);
        square2(5.5f);
        square3(5.5);
        square4(523434543);

        static void square1(int a)
        {
            Console.WriteLine($"{a*a}");
        }

        static void square2(float a)
        {
            Console.WriteLine($"{a*a}");
        }

        static void square3(double a)
        {
            Console.WriteLine($"{a*a}");
        }

        static void square4(long a)
        {
            Console.WriteLine($"{a*a}");
        }
    }
}