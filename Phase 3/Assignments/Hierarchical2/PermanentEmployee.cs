using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hierarchical1
{
    public class PermanentEmployee: SalaryInfo
    {
        public string EmployeeID { get; set; }
        public string  EmployeeType { get; set; }

        public double DA { get; set; }
        public double HRA { get; set; }
        public double PF { get; set; }
        public double TotalSalary { get; set; }
        public PermanentEmployee(string employeeID, string type, double salary, double month)
        {
            EmployeeID = employeeID;
            EmployeeType = type;
            BasicSalary = salary;
            Month  = month;
            DA = (0.2/100.0)*BasicSalary;
            HRA = 0.18/100*BasicSalary;
            PF = 0.1/100*BasicSalary;

        }
        public void CalculateTotalSalary()
        {
            TotalSalary = BasicSalary+DA+HRA-PF;
        }
        public void ShowSalary()
        {
            Console.WriteLine($"Your Salary :{TotalSalary}"); 
        }
    }
}