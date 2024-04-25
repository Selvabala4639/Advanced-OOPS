using System;
namespace Abstract3;
class Program{
    public static void Main(string[] args)
    {
        MaruthiSwift maruthi = new MaruthiSwift();
        maruthi.GetEngineType("Diesel");
        maruthi.GetNoOfSeats(4);
        maruthi.GetPrice(200000);
        maruthi.ShowCarDetails();

        SuzukiCiaz suzuki = new SuzukiCiaz();
        suzuki.GetEngineType("Diesel");
        suzuki.GetNoOfSeats(4);
        suzuki.GetPrice(200000);
        suzuki.ShowCarDetails();
    }
}