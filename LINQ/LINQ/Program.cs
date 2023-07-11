using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Program
    {
        class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Address { get; set; }
            public string College { get; set; }
        }
        static void Main(string[] args)
        {

            // Create a list of students
            List<Student> students = new List<Student>();

            // Add details of five students
            students.Add(new Student { FirstName = "Saksham", LastName = "Khanal", Address = "Lalitpur", College = "KCT" });
            students.Add(new Student { FirstName = "Bibke", LastName = "Karki", Address = "Kathmandu", College = "KCT" });
            students.Add(new Student { FirstName = "Roshan", LastName = "sth", Address = "Lalitpur", College = "BKT campus" });
            students.Add(new Student { FirstName = "Niusm", LastName = "Giri", Address = "Lalitpur", College = "KCT" });
            students.Add(new Student { FirstName = "Sita", LastName = "Karki", Address = "Bhaktapur", College = "GGIC" });

            // LINQ query to filter records and order by first name descending
            var filteredStudents = from student in students
                                   where student.Address == "Lalitpur" && student.College == "KCT"
                                   orderby student.FirstName descending
                                   select student;

            // Print the filtered and ordered students' details
            Console.WriteLine("Students with Address 'Lalitpur' and College 'KCT' (Ordered by First Name Descending):");
            foreach (var student in filteredStudents)
            {
                Console.WriteLine($"Name: {student.FirstName} {student.LastName}, Address: {student.Address}, College: {student.College}");
            }

        }
    }
}
