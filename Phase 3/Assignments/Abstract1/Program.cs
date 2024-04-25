using System;
namespace Abstract1;
class Program
{
    public static void Main(string[] args)
    {
        Cylinder cylinder = new Cylinder(10.0,15.0);
        cylinder.CalculateArea();
        cylinder.CalculateVolume();

        Console.WriteLine($"Cylinder Area : {cylinder.Area}");
        Console.WriteLine($"Cylinder Volume : {cylinder.Volume}");

        Cube cube = new Cube(20.0);
        cube.CalculateArea();
        cube.CalculateVolume();
        Console.WriteLine($"Cube Area : {cube.Area}");
        Console.WriteLine($"Cube Volume : {cube.Volume}");

    }
}