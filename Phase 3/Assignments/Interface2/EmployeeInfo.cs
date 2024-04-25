using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interface2
{
    public class EmployeeInfo: IDisplayInfo
    {
        //Properties: EmployeeID, Name, FatherName
        public string EmployeeID { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        //Methods: Display
        public EmployeeInfo(string employeeID, string name, string fatherName)
        {
            FatherName = fatherName;
            Name = name;
            EmployeeID = employeeID;
        }
        public void Display()
        {
            Console.WriteLine($"Employee ID: {EmployeeID}");
            Console.WriteLine($"Employee Name: {Name}");
            Console.WriteLine($"Father name: {FatherName}");
            
        }
    }
}