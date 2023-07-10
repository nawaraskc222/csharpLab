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
            string path = @"C:\Users\nawar\Downloads\\demo.txt";
            string data = "im KCT";
            File.WriteAllText(path, data);

            string appendData = " im studnet of KCT";
            File.AppendAllText(path, appendData);

            string readFile= File.ReadAllText(path);
            Console.WriteLine(readFile);
           
        }
    }
}
