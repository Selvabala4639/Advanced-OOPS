using System;
namespace Hybrid1;
class Program
{
    public static void Main(string[] args)
    {
        Marksheet marksheet = new Marksheet("Sf1001","Selva","Vel","3480948",98,89,99,90);
        marksheet.CalculateUGTotal();
        marksheet.CalculateUGPercentage();
        marksheet.ShowUGMarkSHeet();
    }
}