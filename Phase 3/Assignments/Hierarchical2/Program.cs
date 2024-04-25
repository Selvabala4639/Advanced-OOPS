using System;
namespace Hierarchical1;
class Program{
    public static void Main(string[] args)
    {
        PermanentEmployee permanent = new PermanentEmployee("SF1000","Permanent", 20000,12);
        permanent.CalculateTotalSalary();
        permanent.ShowSalary();

        TemporaryEmployee temporary = new TemporaryEmployee("SF1000","Permanent", 20000,12);
        temporary.CalculateTotalSalary();
        temporary.ShowSalary();
    }
}