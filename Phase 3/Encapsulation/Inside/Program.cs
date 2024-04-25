using System;
namespace Inside;
class Program 

{
    public static void Main(string[] args)
    {
        First first = new First();
        Console.WriteLine(first.PrivateOut); 
        Console.WriteLine(first.PublicNumber);
        //Console.WriteLine(first.ProtectedNumber);
        Second second = new Second();
        Console.WriteLine(second.ProtectedNumberOut);
         Console.WriteLine(second.InternalProtected);
         Console.WriteLine(first.InternalProtected1);
         Console.WriteLine($"{first.InternalProtectedOut}");
         
    }
}