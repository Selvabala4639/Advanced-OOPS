using System;
namespace MultiLevel2;
class Program
{
    public static void Main(string[] args)
    {
        DepartmentDetails department = new DepartmentDetails("CSE", "BE");
        RackInfo rack = new RackInfo(department.DepartmentName, department.Degree,10,10);
        BookInfo book = new BookInfo(rack.DepartmentName, rack.Degree,rack.RackNumber,rack.ColumnNumber,"BID1","C# Book","Author1",2000);
        book.DisplayInfo();
    }
}