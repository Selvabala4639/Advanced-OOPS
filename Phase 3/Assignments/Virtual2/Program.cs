using System;
namespace Virtual2;
class Program
{
    public static void Main(string[] args)
    {
        Dimension dimension = new Dimension(5,6);
        dimension.calculate();
        dimension.DisplayArea();
        Rectangle rectangle = new Rectangle(10,6,dimension.Area);
        rectangle.calculate();
        rectangle.DisplayArea();

        Sphere sphere = new Sphere(5,dimension.Area);
        sphere.calculate();
        sphere.DisplayArea();
    }
}