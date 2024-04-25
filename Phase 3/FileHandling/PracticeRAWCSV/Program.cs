using System;
using System.Collections.Generic;
using System.IO;
namespace PracticeRAW;
class Program
{
    public static void Main(string[] args)
    {
        if(!Directory.Exists("DataFolder"))
        {
            Directory.CreateDirectory("Datafolder");
            Console.WriteLine($"folder created");
        }
        else Console.WriteLine($"Folder already exits.");
        
        if(!File.Exists("Datafolder/Data.csv"))
        {
            File.Create("Datafolder/Data.csv");
            Console.WriteLine($"CSV file created");
        }
        else Console.WriteLine($"CSV file already exits.");
        
        List<PersonalInfo> personalList = new List<PersonalInfo>();
        personalList.Add(new PersonalInfo("selva", "vel"));
        personalList.Add(new PersonalInfo("Avi", "kannan"));
        WriteCSV(personalList);
        ReadCSV();
    }
    static void WriteCSV(List<PersonalInfo> personalList)
    {
        StreamWriter sw = new StreamWriter("Datafolder/Data.csv");
        foreach(PersonalInfo personal in personalList)
        {
            string line = personal.Name+","+personal.FatherName;
            sw.WriteLine(line);
        }
        sw.Close();
    }//WriteCSV ends here

    static void ReadCSV()
    {
        List<PersonalInfo> newPersonalList = new List<PersonalInfo>();
        StreamReader sr = new StreamReader("Datafolder/Data.csv");
        string line = sr.ReadLine();
        while(line!=null)
        {
            string[] value = line.Split(',');
            if(value[0]!="")
            {
                PersonalInfo personal = new PersonalInfo(value[0],value[1]);
                newPersonalList.Add(personal);
            }
            line = sr.ReadLine();
        }
        sr.Close();
        foreach(PersonalInfo personal1 in newPersonalList)
        {
            Console.WriteLine($"Name :{personal1.Name}\nFatherName :{personal1.FatherName}");
            
        }
    }
}