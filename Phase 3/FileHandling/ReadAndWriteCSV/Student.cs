using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReadAndWrite
{
    public enum Gender{Male, Female, Transgender}
    public class Student
    {
        public string Name { get; set; }
        public string FatherName { get; set; }
        public Gender Gender { get; set; }
        public DateTime DOB { get; set; }
        public int TotalMarks { get; set; }

        public Student(string name, string fatherName, Gender gender, DateTime dob, int total)
        {
            Name = name;
            FatherName = fatherName;
            Gender = gender;
            DOB = dob;
            TotalMarks = total;
        }
        public Student()
        {
        }
    }
}