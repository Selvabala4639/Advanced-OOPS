using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polymorphism4
{
    public class FreeLancer : PersonDetails
    {
        public string Role { get; set; }
        public double SalaryAmount { get; set; }
        public int NoOfWorkingDays { get; set; }
        
        public FreeLancer(string name, string fatherName , string gender, string role)
        {
            Name = name;
            FatherName = fatherName;
            Gender = gender;
            Role = role;
        }
        public virtual void CalculateSalary(int noOfWorkingDays)
        {
            NoOfWorkingDays = noOfWorkingDays;
            SalaryAmount = NoOfWorkingDays*500;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"FatherName : {FatherName}");
            Console.WriteLine($"Role : {Role}");
            Console.WriteLine($"SalaryAmount : {SalaryAmount}");
            Console.WriteLine($"NoOfWorkingDays : {NoOfWorkingDays}");
        }
    }
}