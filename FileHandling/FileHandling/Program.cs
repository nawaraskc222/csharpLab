using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{

    internal class Program
    {
          static void Main(string[] args)
        {
            string rootFolder = @"C:\Users\nawar\Downloads";
           
            Directory.CreateDirectory(rootFolder);
        string filePath = Path.Combine(rootFolder, "example.txt");
            File.WriteAllText(filePath, "Im student of KCT.");

            Console.WriteLine("Folder created: " + rootFolder);
            Console.WriteLine("File created: " + filePath);
            Console.WriteLine("Enter a folder path:");
            string selectedFolder = Console.ReadLine();

            if (Directory.Exists(selectedFolder))
            {
                Console.WriteLine("Selected folder: " + selectedFolder);
            }
            else
            {
                Console.WriteLine("Invalid folder path!");
            }
         Console.WriteLine("Enter a file path:");
            string selectedFile = Console.ReadLine();

            if (File.Exists(selectedFile))
            {
                Console.WriteLine("Selected file: " + selectedFile);
                string data=File.ReadAllText(selectedFile);
                Console.WriteLine(data);
            }
            else
            {
                Console.WriteLine("Invalid file path!");
            }


        }
    }
}
