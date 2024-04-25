using System;

namespace PartialClassesAndMethods;
class Program 
{
    public static void Main(string[] args)
    {
        PersonalDetails personal = new PersonalDetails();
        personal.DOB = new DateTime(2001,11,22);
        Console.WriteLine(personal.CalculateAge());
    }
}