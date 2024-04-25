using System;
using System.IO;
namespace Filefolder;
class Program{
    public static void Main(string[] args)
    {
        string path = @"D:\C# programs\Phase 3\FileHandling\MyFolder";
        string folderPath = path +"/Selva";
        if(!Directory.Exists(folderPath))
        {
            Console.WriteLine($"Creating Folder...");
            Directory.CreateDirectory(folderPath);
            
        }
        else 
        {
            Console.WriteLine($"Folder already exits.");
            
        }
        string filePath = path+"/myfile.txt";
        if(!File.Exists(filePath))
        {
            Console.WriteLine($"Creating file...");
            File.Create(filePath);
        }
        else
        {
            Console.WriteLine($"File already exits.");
        }
        Console.WriteLine($"1.Create folder\n2. Create file\n3.Delete folder\n4.Delete file");
        int option = int.Parse(Console.ReadLine());
        switch(option)
        {
            case 1:
            {
                Console.Write($"Enter folder name you want to create: ");
                string folder = Console.ReadLine();
                string newPath = path+"/"+folder;
                if(!Directory.Exists(newPath))
                {
                    Console.WriteLine($"Creating folder {folder}");
                    Directory.CreateDirectory(newPath);  
                }
                else
                {
                    Console.WriteLine($"Folder already exits.");
                }
                break;
            }
            case 2:
            {
                  Console.WriteLine($"Enter file name you want to create.");
                  string fileName = Console.ReadLine();
                  Console.WriteLine($"Enter file extension name.");
                  string fileExtension = Console.ReadLine();
                  string newFilePath = path+ "/" +fileName+"."+fileExtension;
                  if(!File.Exists(filePath))
                  {
                    Console.WriteLine($"Creating file {fileName}.{fileExtension}");
                    File.Create(newFilePath);
                  }
                  else
                  {
                    Console.WriteLine($"File already exits.");
                  }
                break;
            }
            case 3:
            {
                foreach(string path1 in Directory.GetDirectories(path))
                {
                    Console.WriteLine($"{path1}");
                }
                Console.WriteLine($"Select the folder wish to remove.");
                string selectFolder = Console.ReadLine();
                foreach(string currentPath in Directory.GetDirectories(path))
                {
                    if(currentPath.Contains(selectFolder))
                    {
                        Directory.Delete(currentPath);
                        Console.WriteLine($"{selectFolder} is removed.");
                    }
                }
                break;
            }
            case 4:
            {
                foreach(string currentFile in Directory.GetFiles(path))
                {
                    Console.WriteLine($"{currentFile}");
                }
                Console.WriteLine($"Select file to remove with extension.");
                string selectFile = Console.ReadLine();
                foreach(string currentFile in Directory.GetFiles(path))
                {
                    if(currentFile.Contains(selectFile))
                    {
                        File.Delete(currentFile);
                        Console.WriteLine($"{selectFile} is removed.");
                    }
                }
                break;
            }
        }
        
    }
}