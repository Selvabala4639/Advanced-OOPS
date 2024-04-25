using System;
using System.Collections.Generic;
namespace MultiLevel1;
class Program
{
    public static void Main(string[] args)

    {
         List<PersonalInfo> personalList = new List<PersonalInfo>();
         List<StudentInfo> studentList = new List<StudentInfo>();
         List<HSCDetails> HscList = new List<HSCDetails>();
        PersonalInfo personal1 = new PersonalInfo("Selva", "Vel", "9024976614", "selva@gamil", new DateTime(2001,11,22),"male");
        PersonalInfo personal2 = new PersonalInfo("Praveen", "Siva", "9843939385", "praveen@gamil", new DateTime(2001,05,02),"male");

        personalList.Add(personal1);
        personalList.Add(personal2);

        // StudentInfo student1 = new StudentInfo(personal1.Name, personal1.FatherName, personal1.Phone, personal1.Mail,personal1.DOB,personal1.Gender);
        // Console.WriteLine($"Getting Student 1 details: ");
        
        // student1.GetStudentDetails();
        // student1 = new StudentInfo(personal1.Name, personal1.FatherName, personal1.Phone, personal1.Mail,personal1.DOB,personal1.Gender,student1.RegisterNumber,student1.Standard,student1.Branch,student1.AcadamicYear);
        // studentList.Add(student1);
        // Console.WriteLine($"Student 1 details");
        // student1.ShowStudentInfo();
        
        // StudentInfo student2 = new StudentInfo(personal2.Name, personal2.FatherName, personal2.Phone, personal2.Mail,personal2.DOB,personal2.Gender);
        // Console.WriteLine($"Getting Student 2 details: ");
        // student2.GetStudentDetails();
        // studentList.Add(student2);
        // Console.WriteLine($"Student 2 details");
        // student2.ShowStudentInfo();


        int count =0;
        foreach(PersonalInfo personal in personalList)
        {
            count++;
            StudentInfo student= new StudentInfo(personal.Name, personal.FatherName, personal.Phone, personal.Mail,personal.DOB,personal.Gender);
            Console.WriteLine($"Getting student {count} details ");
            student.GetStudentDetails();
            student = new StudentInfo(personal1.Name, personal1.FatherName, personal1.Phone, personal1.Mail,personal1.DOB,personal1.Gender,student.RegisterNumber,student.Standard,student.Branch,student.AcadamicYear);
            studentList.Add(student);
            Console.WriteLine($"Student {count} details");
            student.ShowStudentInfo();
            HSCDetails hscdetail = new HSCDetails(student.Name, student.FatherName,student.Phone,student.Mail,student.DOB, student.Gender, student.RegisterNumber,student.Standard,student.Branch,student.AcadamicYear);
            HscList.Add(hscdetail);
            hscdetail.GetMarks();
            hscdetail.CalculateTotal();
            hscdetail.CalculatePercentage();
            Console.Write($"Do you want to see Mark Sheet (yes/no) : ");
            string choice = Console.ReadLine();
            if(choice =="yes")
            {
                hscdetail.ShowMarSheet();
            }
        }
    }
}