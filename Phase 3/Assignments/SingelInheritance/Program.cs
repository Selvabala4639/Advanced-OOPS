using System;
using SingelInheritance;
namespace SingleInheritance;

class Program
{
    public static void Main(string[] args)
    {
        //Name, FatherName, Phone ,Mail, DOB, Gender
        //RegisterNumber, Standard, Branch, AcadamicYear
        PersonalInfo personal = new PersonalInfo("Selva", "Vel", "9024976614", "selva@gamil", new DateTime(2001,11,22),"male");
        StudentInfo student = new StudentInfo(personal.Name, personal.FatherName, personal.Phone, personal.Mail,personal.DOB,personal.Gender,"SF4639","12","CS",2023);

Console.WriteLine($"Name: {student.Name}\nFatherName: {student.FatherName}\nPhone: {student.Phone}\nMail: {student.Mail}\nDOB: {student.DOB}\nGender: {student.Gender}\nRegisterNumber: {student.RegisterNumber}\nStandard: {student.Standard}\nBranch: {student.Branch}\nAcadamicYear: {student.AcadamicYear}");
    }
}