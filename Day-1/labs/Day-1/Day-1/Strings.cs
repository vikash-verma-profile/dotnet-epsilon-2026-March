using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace Day_1
{
    struct Employee
    {
        public int Id;
        public string Name;
    };

    enum Days
    {
        Sunday,
        Monday
    }
    internal class Strings
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("Vikash");
            sb.Append("Verma");


            dynamic x = 1;
            Console.WriteLine(x.GetType());
            x = "Vikash";
            Console.WriteLine(x.GetType());
            Console.WriteLine(x);

            string s = "sam";
            char[] chars = new char[] { 's', 'a', 'm' };

            Console.WriteLine(s==chars.ToString());
            Console.WriteLine(s.Equals(chars));
            Class1 class1 = new Class1();
            class1.Sum(1,2);

            int a = 4;
            object sample = a;//boxing
            a =(int)sample;
            Console.WriteLine(sample);

            Console.WriteLine("====ENums");
            Console.WriteLine((int)Days.Monday);
            Console.WriteLine((int)Days.Sunday);

            Employee e;
            e.Id = 1;
            e.Name= "Test";

            Console.WriteLine($"{e.Id}-{e.Name}");

        }
    }
}
