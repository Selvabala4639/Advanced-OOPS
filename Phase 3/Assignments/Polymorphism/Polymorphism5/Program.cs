using System;
namespace Polymorphism5;
class Program{
    public static void Main(string[] args)
    {
        EmployeeInfo employee = new EmployeeInfo("Selva","vel","3480480","male","SF1001");
        employee.Display();
        SalaryInfo salary = new SalaryInfo(20,employee.Name, employee.FatherName,employee.Mobile,employee.Gender,employee.EmployeeID);
        salary.Display();
    }
}