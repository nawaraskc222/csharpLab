using System;
using System.Management.Instrumentation;

namespace LEARNDEMO
{
    internal class Program
    {
      
         enum level
        {
            low,mid,high
        }
        struct Name
        {
            public int age;
            public string AddName { get; set; }
        }

        static void Main(string[] args)
            {
            level n1 = level.high;
            int n2 = (int)level.high;
            Console.WriteLine(n1);
            Console.WriteLine(n2);

            Name n= new Name();
            n.age = 90;

            n.AddName = "Ram";
                Console.WriteLine(n.AddName);
                Console.WriteLine(n.age);

        }
        }
    }

