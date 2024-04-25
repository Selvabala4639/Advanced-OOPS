using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interface2
{
    public class StudentInfo :IDisplayInfo
    {
        //Properties: StudentID, Name, FatherName, Mobile

        public string StudentID { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string Mobile { get; set; }

        public StudentInfo(string id, string name, string fatherName, string mobile)
        {
            StudentID = id;
            Name = name;
            FatherName = fatherName;
            Mobile = mobile;
        }
        //Methods: Display
        public void Display()
        {
            Console.WriteLine($"Student ID: {StudentID}");
            Console.WriteLine($"Student Name: {Name}");
            Console.WriteLine($"Father name: {FatherName}");
            Console.WriteLine($"Mobile: {Mobile}");
        }
    }
}