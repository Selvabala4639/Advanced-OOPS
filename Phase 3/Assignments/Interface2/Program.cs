using System;
namespace Interface2;
class Program
{
    public static void Main(string[] args)
    {
        StudentInfo student= new StudentInfo("Sf48239","Selva","vel","23479032");
        student.Display();
        EmployeeInfo employee= new EmployeeInfo("SID101","selva","vel");
        employee.Display();
    }
}