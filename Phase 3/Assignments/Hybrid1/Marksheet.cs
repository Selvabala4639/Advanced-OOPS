using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hybrid1
{
    public class Marksheet : TheoryExamMarks, ICalculate
    {
        public double ProjectMark { get; set; }
        public string MarkSheetNumber { get; set; }
        public DateTime DateOfIssue { get; set; }
        public double Total { get; set; }
        public double Percentage { get; set; }
        public Marksheet(string reg, string name, string fatherName, string phone, double sem1, double sem2, double sem3, double sem4)
        {
            RegisterNumber = reg;
            Name = name;
            FatherName = fatherName;
            Phone = phone;
            Sem1 = sem1;
            Sem2 = sem2;
            Sem3 = sem3;
            Sem4 = sem4;
        }
        public void CalculateUGTotal()
        {
            Total = Sem1+Sem2+Sem3+Sem4;
        }
        public void CalculateUGPercentage()
        {
            Percentage = (Total/400)*100;
        }
        public void ShowUGMarkSHeet()
        {
            Console.WriteLine($"RegisterNumber: {RegisterNumber}");
            Console.WriteLine($"Sem1: {Sem1}");
            Console.WriteLine($"Sem2: {Sem2}");
            Console.WriteLine($"Sem3: {Sem3}");
            Console.WriteLine($"Sem4: {Sem4}");
            Console.WriteLine($"Total: {Total}");
            Console.WriteLine($"Percentage: {Percentage}");
            
        }

    }
}