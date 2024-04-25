using System;
namespace Polymorphism6;
class Program{
    public static void Main(string[] args)
    {
        //Bank bank = new Bank();
        SBI sBI = new SBI();
        double sbi = sBI.GetIntresetInfo(2000);
        Console.WriteLine($"{sbi}");
        HDFC hdfc = new HDFC();
        double hdfcResult = hdfc.GetIntresetInfo(2000);
        Console.WriteLine($"{hdfcResult}");

        ICICI icici = new ICICI();
        Console.WriteLine($"{icici.GetIntresetInfo(3000)}");

        IDBI  idbi = new IDBI();
        Console.WriteLine($"{idbi.GetIntresetInfo(400)}");
    }
}