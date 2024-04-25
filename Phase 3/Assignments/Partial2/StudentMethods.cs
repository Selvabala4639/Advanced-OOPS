using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Partial2
{
    public partial class StudentInfo
    {
        public void CalculateTotal()
        {
            Total = Physics+Chemistry+Maths;
        }

        public void CalculatePercentage()
        {
            Percentage = (Total*100)/300;
        }
        public void Display()
        {
            Console.WriteLine($"Student ID: {StudentID}");
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Gender: {Gender}");
            Console.WriteLine($"DOB: {DOB}");
            Console.WriteLine($"Mobile: {Mobile}");
            Console.WriteLine($" Physics Mark: {Physics}");
            Console.WriteLine($" Chemistry Mark: {Chemistry}");
            Console.WriteLine($" Maths Mark: {Maths}");
            Console.WriteLine($" Total Mark: {Total}");
            Console.WriteLine($" Percentage: {Percentage}");
        }
    }
}