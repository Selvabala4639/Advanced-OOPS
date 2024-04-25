using System;
namespace Sealed1;
class Program
{
    public static void Main(string[] args)
    {
        PersonalInfo personal = new PersonalInfo();
        personal.UpdateInfo();
        EmployeeInfo employee = new EmployeeInfo();
        employee.UpdateInfo();
        employee.DisplayInfo();
        Hack hack = new Hack();
    }
}