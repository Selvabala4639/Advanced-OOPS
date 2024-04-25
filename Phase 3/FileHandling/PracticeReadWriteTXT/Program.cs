using System;
using System.IO;
namespace PracticeReadWriteTXT;
class Program
{
    public static void Main(string[] args)
    {
        if(!Directory.Exists("Textfolder"))
        {
            Directory.CreateDirectory("TextFolder");
            Console.WriteLine($"folder created.");
        }
        else Console.WriteLine($"Folder already exists.");
        
        if(!File.Exists("TextFolder/Data.txt"))
        {
            File.Create("TextFolder/Data.txt").Close();
            Console.WriteLine($"File created.");
        }
        else Console.WriteLine($"File already exists.");
        
        string[] contents = File.ReadAllLines("TextFolder/Data.txt");
        StreamWriter sw  =  new StreamWriter("TextFolder/Data.txt");
        Console.WriteLine($"Enter content to add to the file.");
        string data = Console.ReadLine();
        string old = "";
        foreach(string line in contents)
        {
            old = old+line+"\n";
        }
        old = old +data ;
        sw.WriteLine(old);
        sw.Close();

        StreamReader sr = new StreamReader("TextFolder/Data.txt");
        string readLine = sr.ReadLine();
        while(readLine!=null)
        {
            Console.WriteLine($"{readLine}");
            readLine= sr.ReadLine();
        }
        sr.Close();
    }
}