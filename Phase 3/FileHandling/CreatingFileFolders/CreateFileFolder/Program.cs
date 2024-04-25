using System;
using System.IO;
namespace CreatFileFolder;
class Program
{
    public static void Main(string[] args)
    {
        string path = @"D:\C# programs\Phase 3\FileHandling\CreatingFileFolders\myFolder";
        Console.WriteLine($"1.Create folder\n2.Create File\n3.Delete Folder\n4.Delete file");
        int option = int.Parse(Console.ReadLine());
        switch(option)
        {
            case 1 :
            {
                Console.WriteLine($"Enter folder name to create folder.");
                string folderName = Console.ReadLine();
                string folderPath = path+"/"+folderName;
                if(!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                    Console.WriteLine($"{folderName} is created.");
                }
                else{
                    Console.WriteLine($"{folderName} already exits.");
                }
                break;
            }
            case 2 :
            {
                Console.WriteLine($"Enter file name you wish to create with extension.");
                string fileName = Console.ReadLine();
                string filePath = path+"/"+fileName;
                if(!File.Exists(filePath))
                {
                    File.Create(filePath);
                    Console.WriteLine($"{fileName} is created.");
                }
                else{
                    Console.WriteLine($"Already exists.");
                    
                }
                break;
            }
            case 3 :
            {
                foreach(string currentFolder in Directory.GetDirectories(path))
                {
                    Console.WriteLine($"{currentFolder}");
                }
                Console.WriteLine($"enter folder name to delete.");
                string selectFolder = Console.ReadLine();
                foreach(string currentPath in Directory.GetDirectories(path))
                {
                    if(currentPath.Contains(selectFolder))
                    {
                        Directory.Delete(currentPath);
                        Console.WriteLine($"{selectFolder} is deleted");
                    }
                }
                break;
            }
            case 4 :
            {
                foreach(string currentPath in Directory.GetFiles(path))
                {
                    Console.WriteLine($"{currentPath}");
                }
                Console.WriteLine($"Select file to remove.");
                string selectFile = Console.ReadLine();
                foreach(string currentPath in Directory.GetFiles(path))
                {
                    if(currentPath.Equals(path+"\\"+selectFile))
                    {
                        File.Delete(currentPath);
                        Console.WriteLine($"{selectFile} is deleted.");
                    }
                }
                
                break;
            }
        }
        
    }
}