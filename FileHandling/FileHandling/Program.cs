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
           

            // Create a folder
            Directory.CreateDirectory(rootFolder);

            // Create a file within the folder
            string filePath = Path.Combine(rootFolder, "example.txt");
            File.WriteAllText(filePath, "Im student of KCT.");

            // Display folder and file information
            Console.WriteLine("Folder created: " + rootFolder);
            Console.WriteLine("File created: " + filePath);

            // Select a folder
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

            // Select a file
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
