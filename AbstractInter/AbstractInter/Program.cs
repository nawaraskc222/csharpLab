using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInter
{


    interface Vehicels
    {
        void Tires();
    }


    class Bike : Vehicels
    {
        public void Tires()
        {
            Console.WriteLine("Bike has got two tires");
        }
    }


    abstract class Animal
    {
        public abstract void Sound();
        public void Eat()
        {
            Console.WriteLine("Eat:True");
        }
    }


    class Dog : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Bark");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog d1 = new Dog();
            d1.Eat();
            d1.Sound();


            Bike b1 = new Bike();
            b1.Tires();
        }
    }
}
