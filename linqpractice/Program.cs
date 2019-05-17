using System;
using System.Linq;
using System.Collections.Generic;

namespace linqpractice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Eden", 12));
            students.Add(new Student("Eve", 6));
            students.Add(new Student("Arlo", 2));

            IEnumerable<Student> lessThanSix = students
                        .Where(s => s.age < 33)
                        .Where(x => x.name.StartsWith("A"));

            IEnumerable<String> list =
                from s in students
                where s.age < 5
                where s.name.StartsWith("E")
                select s.name;

            IEnumerable<string> lessThanSixOnly = students
                        .Where(s => s.age < 33)
                        .Where(x => x.name.StartsWith("A"))
                        .Select(s => s.name);

            IEnumerable<string> lessThanSixOnly2 = students
                        .Where(s => s.age < 33) //student goes in, student comes out
                        .Select(s => s.name) //string goes in, string comes out
                        .Where(x => x.StartsWith("E") || x.StartsWith("A"));// student goes in, string comes out


            foreach(string s in lessThanSixOnly2)
            {
                Console.WriteLine(s);
            }
        }

        // bool filter(Student s)
        // {
        //     return s.age < 6;
        // }

        // bool filter2(Student x)
        // {
        //     return x.name.StartsWith("E");
        // }

    }

    class Student
    {
        public string name;
        public int age;
        public Student(string iName, int iAge)
        {
            this.name = iName;
            this.age = iAge;
        }
    }
}
