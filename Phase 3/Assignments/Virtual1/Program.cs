using System;
namespace Virtual1;
class Program
{
    public static void Main(string[] args)
    {
        AreaCalculator area = new AreaCalculator(5);
        area.Calculate();
        area.Display();
        VolumeCalculator volume = new VolumeCalculator(area.Radius,10.0);
        volume.Calculate();
        volume.Display();
    }
}