using System;
using System.IO;
using System.Collections.Generic;
namespace ReadAndWrite;
class Program
{
    public static void Main(string[] args)
    {
        if(!Directory.Exists("TestFolder"))
        {
            Console.WriteLine($"creating folder...");
            Directory.CreateDirectory("Testfolder");
        }
        else{
            Console.WriteLine($"Already exits.");
        }
        //CSV file
        if(!File.Exists("Testfolder/Data.csv"))
        {
            Console.WriteLine($"Creating data.csv...");
            File.Create("Testfolder/Data.csv");
        }
        else Console.WriteLine($"CSV file already exits.");
        
        //Jason file
        // if(!File.Exists("Testfolder/Data1.json"))
        // {
        //     Console.WriteLine($"Creating data.json...");
        //     File.Create("Testfolder/Data1.json");
        // }
        // else Console.WriteLine($"JSON file already exits.");

        List<Student> studentList = new List<Student>();
        studentList.Add(new Student("Selva","Vel",Gender.Male,new DateTime(2001,11,22),400));
        studentList.Add(new Student("Avi","kannan",Gender.Female,new DateTime(2001,05,03),500));
        studentList.Add(new Student("mohan","veer",Gender.Male,new DateTime(2001,09,17),420));
        WritetoCSV(studentList);
        ReadCSV();
    } 
    static void WritetoCSV(List<Student> studentList)
    {
        StreamWriter sw = new StreamWriter("Testfolder/Data.csv");
        foreach(Student student in studentList)
        {
            string line = student.Name+","+student.FatherName+","+student.Gender+","+student.DOB.ToString("dd/MM/yyyy")+","+student.TotalMarks;
            sw.WriteLine(line);
        }
        sw.Close();
    }

    static void ReadCSV()
    {
        List<Student> newList = new List<Student>();
        StreamReader sr = new StreamReader("Testfolder/Data.csv");
        string line = sr.ReadLine();
        while(line!=null)
        {
            string[] value = line.Split(',');
            if(value[0]!="")
            {
                Student student = new Student()
                {
                    Name = value[0],
                    FatherName = value[1],
                    Gender = Enum.Parse<Gender>(value[2]),
                    DOB = DateTime.ParseExact(value[3],"dd/MM/yyyy",null),
                    TotalMarks = int.Parse(value[4])
                };
                newList.Add(student);
            }
            line = sr.ReadLine();
        }
        sr.Close();
        foreach(Student student in newList)
        {
            Console.WriteLine($"Name :{student.Name}");
            Console.WriteLine($"FatherName :{student.FatherName}");
            Console.WriteLine($"DOB :{student.DOB}");
            Console.WriteLine($"Gender :{student.Gender}");
        }
    }
}