using System;
using System.IO;
namespace ReadWriteTXT;
class Program
{
    public static void Main(string[] args)
    {
        if(!Directory.Exists("TestFolder"))
        {
            Directory.CreateDirectory("TestFolder");
            Console.WriteLine($"Folder created");
        }
        else Console.WriteLine($"Folder already exits.");
        if(!File.Exists("TestFolder/MyFile.txt"))
        {
            File.Create("TestFolder/MyFile.txt").Close();
            Console.WriteLine($"File created.");
        }
        else Console.WriteLine($"File already exists.");
        
        Console.WriteLine($"1.Read from file\n2.Write from file.");
        int option = int.Parse(Console.ReadLine());
        switch(option)
        {
            case 1:
            {
                StreamReader sr = new StreamReader("Testfolder/MyFile.TXT");
                string line = sr.ReadLine();
                while(line!=null)
                {
                    Console.WriteLine($"{line}");
                    line = sr.ReadLine();
                }
                sr.Close();
                break;
            }
            case 2:
            {
                string [] contents = File.ReadAllLines("Testfolder/MyFile.TXT");
                StreamWriter sw = new StreamWriter("Testfolder/MyFile.TXT");
                Console.WriteLine($"Write th econtent you want to add to the text file.");
                string data = Console.ReadLine();
                string old ="";
                foreach(string line in contents)
                {
                    old = old+line+"\n";
                }
                old = old + data+"\n";
                sw.WriteLine(old);
                sw.Close();
                break;
            }
        }
        
    }
}