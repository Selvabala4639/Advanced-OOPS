using System;
namespace Multiple2;
class Program{
    public static void Main(string[] args)
    {
        Eco eco = new Eco("Eco","en1","cha1","eco",4,"blue",20,39999);
        eco.ShowDetails();

        ShiftDezire shift = new ShiftDezire("ShiftDezire","en2","cha2","diesel",4,"red",20,2900);
        shift.ShowDetails();
    }
}