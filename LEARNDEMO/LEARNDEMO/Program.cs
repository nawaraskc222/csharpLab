using System;
using System.Management.Instrumentation;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace LEARNDEMO
{

    public interface Nawars
    {
        void Son();
        void Daughter();
    }


    class ChoraChori: Nawars
    {
        public void Son()
        {
            Console.WriteLine("Dad,Bike");
        }
        public void Daughter()
        {
            Console.WriteLine("Dady,Pink Shirt");
        }
    }
     class Program 
    {
        
        static void Main(string[] args)
        {

            ChoraChori c = new ChoraChori();
            c.Son();
            c.Daughter();   

        }
    }
}

