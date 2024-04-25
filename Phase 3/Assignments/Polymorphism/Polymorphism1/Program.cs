using System;
using System.Security.Cryptography.X509Certificates;
namespace Polymorphism1;
class Program{
    public static void Main(string[] args)
    {
        method1( 4);
        method2(4,5);
        method3(1,2,3);
        method4(2,3.5);
        method5(2,2.5,3);
        static void  method1(int a)
        {
            Console.WriteLine($"Method with 1 arg ");
            Console.WriteLine($"{a*a}");
        }

        static void method2(int a , int b)
        {
            Console.WriteLine($"Method with 2 arg ");
            Console.WriteLine($"{a*a}");
            Console.WriteLine($"{b*b}");
        }
        static void method3(int a , int b, int c)
        {
            Console.WriteLine($"Method with 3 arg ");
            Console.WriteLine($"{a*a}");
            Console.WriteLine($"{b*b}");
            Console.WriteLine($"{c*c}");
        }
        static void method4(int a, double b)
        {
            Console.WriteLine($"Method with 2 arg with different data types");
            Console.WriteLine($"{a*a}");
            Console.WriteLine($"{b*b}");
        }

        static void method5(int a, double b, int c)
        {
            Console.WriteLine($"Method with 3 arg with different data types");
            Console.WriteLine($"{a*a}");
            Console.WriteLine($"{b*b}");
            Console.WriteLine($"{c*c}");
        }
    }
}