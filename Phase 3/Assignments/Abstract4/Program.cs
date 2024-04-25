using System;
namespace Abstract4;
class Program{
    public static void Main(string[] args)
    {
        Ladieswear ladieswear = new Ladieswear();
        ladieswear.GetDressInfo("ladies", "Saree",200,200);
        ladieswear.DisplayInfo();

        Menswear menswear = new Menswear();
        menswear.GetDressInfo("mens","shirts",500,500);
        menswear.DisplayInfo();
    }
}