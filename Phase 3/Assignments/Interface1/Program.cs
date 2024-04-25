using System;
namespace Interface1;
class Program
{
    public static void Main(string[] args)
    {
        Dog dog = new Dog("Ghost","Domestic","Chewing");
        dog.DisplayInfo();
        Dog dog1 = new Dog("Dog2","Wild","Eatinghabi2");
        dog1.DisplayInfo();

        Duck duck1 = new Duck("Duck1","Domestic","eatinghabit1");
        duck1.DisplayInfo();
        Duck duck2 = new Duck("Duck2","Domestic2","eatinghabit2");
        duck2.DisplayInfo();
    }
}