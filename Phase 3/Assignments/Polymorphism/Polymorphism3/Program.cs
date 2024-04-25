using System;
namespace Polymorphism3;
class Program{
    public static void Main(string[] args)
    {
        CSEDEpartment cse = new CSEDEpartment();
        EEEDepartment eee = new EEEDepartment();
        cse.SetBookInfo("Author1", "Book1", "Publisher1", 2022);
        cse.DisplayInfo();
        eee.SetBookInfo("Author2", "Book2", "Publisher2", 2023);
        eee.DisplayInfo();
    }
}