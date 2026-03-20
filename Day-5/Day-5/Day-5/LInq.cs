using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    internal class LInq
    {
        public static void Main()
        {
            List<int> ints=new List<int>();
            ints.Add(1);
            ints.Add(2);
            ints.Add(3);
            ints.Add(4);
            ints.Add(5);

            //var isfound = ints.Where(x => x == 6).FirstOrDefault();
            var isfound = ints.FirstOrDefault(x => x == 2);
            Console.WriteLine(isfound);

            List<Student> students = new List<Student>();
            students.Add(new Student {Id=1,Name="Vikash" });
            students.Add(new Student { Id = 2, Name = "Rahul" });
            students.Add(new Student { Id = 3, Name = "Rakesh" });
            students.Add(new Student { Id = 4, Name = "SUkesh" });
            //Console.WriteLine("=========TAKE========");
            //students=students.Take(3).ToList();
            //foreach (var item in students)
            //{
            //    Console.WriteLine($"{item.Id}-{item.Name}");
            //}
            //Console.WriteLine("=================");
            //Console.WriteLine("=========SKIP========");
            //students = students.Skip(1).ToList();
            //foreach (var item in students)
            //{
            //    Console.WriteLine($"{item.Id}-{item.Name}");
            //}
            //Console.WriteLine("=================");
            //var student = students.Where(x=>x.Name.Contains("Rahul"));
            //foreach (var item in student)
            //{
            //    Console.WriteLine($"{item.Id}-{item.Name}");
            //}
            var studentList=students.Select(x => x.Name).ToList();
            foreach (var item in studentList)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}
