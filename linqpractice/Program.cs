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

            IEnumerable<Student> lessThansix = students.Where(s => s.age < 6);
        }

        bool filter(Student s)
        {
            return s.age < 6;
        }
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
