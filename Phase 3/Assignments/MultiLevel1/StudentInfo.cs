using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiLevel1
{
    public class StudentInfo: PersonalInfo
    {
        public string RegisterNumber { get; set; }
        public string Standard { get; set; }
        public string Branch { get; set; }
        public int AcadamicYear { get; set; }

        public StudentInfo(string name, string fatherName, string phone ,string mail, DateTime dob, string gender):base( name,  fatherName,  phone , mail,  dob,  gender)
        {
        }
        public StudentInfo(string name, string fatherName, string phone ,string mail, DateTime dob, string gender,string registerNumber, string standard, string branch, int academicYear):base( name,  fatherName,  phone , mail,  dob,  gender)
        {
            RegisterNumber = registerNumber;
            Standard = standard;
            Branch = branch;
            AcadamicYear = academicYear;
        }
        public void GetStudentDetails()
        {
            Console.WriteLine($"Enter RegisterNumber: ");
            RegisterNumber = Console.ReadLine();
            Console.WriteLine($"Enter Standard: ");
            Standard = Console.ReadLine();
            Console.WriteLine($"Enter Branch: ");
            Branch = Console.ReadLine();
            Console.WriteLine($"Enter Academic Year: ");
            AcadamicYear = int.Parse(Console.ReadLine());
        }
        public void ShowStudentInfo()
        {
            Console.WriteLine($"Name: {Name}\nFatherName: {FatherName}\nPhone: {Phone}\nMail: {Mail}\nDOB: {DOB}\nGender: {Gender}\nRegisterNumber: {RegisterNumber}\nStandard: {Standard}\nBranch: {Branch}\nAcadamicYear: {AcadamicYear}");
        }
    }
}