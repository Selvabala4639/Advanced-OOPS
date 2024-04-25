using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polymorphism5
{
    public class EmployeeInfo :PersonalInfo
    {
        public string EmployeeID { get; set; }
        public EmployeeInfo(string name, string father, string mobile, string gender, string id)
        {
            EmployeeID = id;
            Name = name ;
            FatherName = father;
            Gender = gender;
            Mobile = mobile;
        }
        public EmployeeInfo()
        {
            
        }
        public override void Display()
        {
            Console.WriteLine($"EmployeeID: {EmployeeID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"FatherName: {FatherName}");
            Console.WriteLine($"Gender: {Gender}");
            Console.WriteLine($"Mobile: {Mobile}");
        }
    }
}