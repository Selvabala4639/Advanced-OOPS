using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Partial1
{
    public partial class EmployeeInfo
    {
        //Update, Display

        public void Update()
        {
            Console.Write($"Employee Name: ");
            EmployeeName = Console.ReadLine(); 
            Console.Write($"Employee Gender: ");
            Gender = Console.ReadLine();
            Console.Write($"Employee DOB: ");
           DOB = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
            Console.Write($"Employee Mobile: ");
            Mobile = Console.ReadLine();
            //EmployeeInfo employee = new EmployeeInfo(name, gender, new DateTime(2001,11,22),"9052946442");

        }
        public void Display()
        {
            Console.WriteLine($"Employee ID: {EmployeeID}\nEmployee Name: {EmployeeName}\nGender: {Gender}\nDOB: {DOB}\nMobile: {Mobile}");
        }
    }
}