using System;
using Partial1;
namespace partial1;
class Program
{
    public static void Main(string[] args)
    {
        EmployeeInfo employee = new EmployeeInfo();
        employee.Update();
        employee.Display();
    }
}