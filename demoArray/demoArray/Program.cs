using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
                 int[,,] arr =
                {
                    { {1, 3, 5}, {2, 4, 6} },
                    { {1, 3, 5}, {2, 4, 6} }
                };

            Console.WriteLine("Elements of the 3D array:");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        Console.WriteLine("arr[{0}, {1}, {2}] = {3}", i, j, k, arr[i, j, k]);
                    }
                }
            }
        }
    }
}
