using System;
using System.Collections.Generic;
using Single_inheritence;

namespace SingleInheritence;
class Program
{
    public static void Main(string[] args)
    {
        List<PersonalDetail> userList = new List<PersonalDetail>();
        PersonalDetail user = new PersonalDetail("Selva", "Vel", Gender.Male,"9025976622");
        userList.Add(user);
        Console.WriteLine($"{user.UserID} {user.UserName} {user.FatherName} {user.Gender} {user.PhoneNumber}");

        StudentDetail student = new StudentDetail(user.UserID,user.UserName, user.FatherName, user.Gender, user.PhoneNumber,12, 2020);
        Console.WriteLine($"{student.UserName}");
    }
}