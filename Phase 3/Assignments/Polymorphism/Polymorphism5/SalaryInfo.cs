using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polymorphism5
{
    public class SalaryInfo :EmployeeInfo
    {
        public int NumberOfDaysWorked { get; set; }
        public SalaryInfo(int workingDays , string name, string father, string mobile, string gender, string id):base(name,  father,  mobile,  gender,  id)
        {
            NumberOfDaysWorked = workingDays;
            EmployeeID = id;
            Name = name ;
            FatherName = father;
            Gender = gender;
            Mobile = mobile;
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Salary: {NumberOfDaysWorked*500}");
        }
    }
}