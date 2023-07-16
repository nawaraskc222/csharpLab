using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamda
{
    internal class Program
    {
        static void Main(string[] args)
        {

          
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

          
            var evenNumbers = numbers.FindAll(num => num % 2 == 0);

           
            var squares = numbers.Select(num => num * num);

          
            Console.WriteLine("Even Numbers:");
            foreach (var num in evenNumbers)
            {
                Console.WriteLine(num);
            }

           
            Console.WriteLine("Squares of Numbers:");
            foreach (var square in squares)
            {
                Console.WriteLine(square);
            }
        }
    }
}
