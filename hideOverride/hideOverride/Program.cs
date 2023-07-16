using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hideOverride
{
    class parent
    {
        public   void Show()
        {
            Console.WriteLine("Im parent");
        }
    }
    class child : parent
    {
        public new void Show()
        {
            Console.WriteLine("IM child and came from override");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
            parent p= new child();
            p.Show();
           
        }
    }
}
