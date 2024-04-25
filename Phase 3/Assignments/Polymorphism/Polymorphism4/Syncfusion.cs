using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polymorphism4
{
    public class Syncfusion: FreeLancer
    {
        public string EmployeeID { get; set; }
        public string Location { get; set; }
        public Syncfusion(string name, string fatherName , string gender,string role, string id, string location):base(name,  fatherName ,  gender, role)
        {
            Name= name;
            FatherName = fatherName;
            Gender = gender;
            EmployeeID = id;
            Location = location;
        }

        public override void CalculateSalary(int noOfWorkingDays)
        {
            NoOfWorkingDays = noOfWorkingDays;
            SalaryAmount = NoOfWorkingDays*500;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"FatherName : {FatherName}");
            Console.WriteLine($"EmployeeID : {EmployeeID}");
            Console.WriteLine($"EmployeeID : {EmployeeID}");
            Console.WriteLine($"Location : {Location}");
            Console.WriteLine($"NoOfWorkingDays : {NoOfWorkingDays}");
            Console.WriteLine($"SalaryAmount : {SalaryAmount}");
        }
    }
}