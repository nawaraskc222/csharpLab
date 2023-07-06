using System;


namespace EnumStruct
{
    enum level { low,middle,high};
    struct student
    {
        public int id;
        public string name;
    };
    internal class Program
    {
        static void Main(string[] args)
        {

            level l = level.low;
            int s= (int)level.high;
            Console.WriteLine(s);
            Console.WriteLine(l);

            student s1= new student();
            s1.id = 1;
            s1.name = "Bibek Karki";
            Console.WriteLine(s1.id);
            Console.WriteLine(s1.name);
        }
    }
}
