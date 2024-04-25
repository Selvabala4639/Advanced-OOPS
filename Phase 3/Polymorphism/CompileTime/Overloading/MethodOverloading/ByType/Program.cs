using System;
namespace ByType;
class Program
{
    public static void Main(string[] args)
    {
        //Add method to add integer
        int result = Add(5,3);
        string resultString = Add("selva ","bala");
        Console.WriteLine(resultString);
        
    }
    public static int Add(int a, int b)
    {
        return a+b;
    }
    public static string Add(string a, string b)
    {
        return a+b;
    }
    
}