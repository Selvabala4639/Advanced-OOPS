using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiLevel1
{
    public class HSCDetails : StudentInfo
    {
        //HSCMarksheetNumber, Physics, Chemistry, Maths, Total, Percentage marks

        public string HSCMarksheetNumber { get; set; }
        public int Physics { get; set; }
        public int Chemistry { get; set; }
        public int Maths { get; set; }
        public int Total { get; set; }
        public double Percentage { get; set; }

        public HSCDetails (string name, string fatherName, string phone ,string mail, DateTime dob, string gender, string registerNumber, string standard, string branch , int academicYear): base(name, fatherName,  phone , mail,  dob,  gender,  registerNumber,  standard,  branch , academicYear)
        {
        }

        // GetMarks, Calculate – Total and percentage, Show Marksheet.

        public void GetMarks()
        {
            Console.Write($"Enter HSC Mark Sheet Number: ");
            RegisterNumber = Console.ReadLine();
            Console.Write($"Enter Physics Mark: ");
            Physics = int.Parse(Console.ReadLine());
            Console.Write($"Enter Chemisrtyysics Mark: ");
            Chemistry = int.Parse(Console.ReadLine());
            Console.Write($"Enter Maths Mark: ");
            Maths = int.Parse(Console.ReadLine());     
        }

        public void CalculateTotal()
        {
            Total = Physics+Chemistry+Maths;
        }

        public void CalculatePercentage()
        {
            Percentage = (Total*100)/300;
        }

        public void ShowMarSheet()
        {
            Console.WriteLine($"HSC Mark Sheet Number: {RegisterNumber}");
            Console.WriteLine($"HSC Physics Mark: {Physics}");
            Console.WriteLine($"HSC Chemistry Mark: {Chemistry}");
            Console.WriteLine($"HSC Maths Mark: {Maths}");
            Console.WriteLine($"HSC Total Mark: {Total}");
            Console.WriteLine($"HSC Percentage: {Percentage}");
        }
    }
}