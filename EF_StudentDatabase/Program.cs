using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_StudentDatabase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SchoolContext())
            {
                var student = new Student() { Name = "Mehmet" , Surname="Can", Age=20, IsFullTime = false};
                context.Students.Add(student);
                context.SaveChanges();
                Console.WriteLine("Student added: " + student.Name+" "+student.Surname);
                Console.ReadKey();
            }
        }
    }
}
