using System;
using System.Collections.Generic;
using System.Linq;


namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 5 student names.");
            string[] students = new string[5];
            for (int i = 0; i < students.Length; i++) {
                Console.WriteLine("Student " +(i+1)+ ": ");
                students[i] = Console.ReadLine();
            }

            Console.WriteLine("Now, enter 3 grades for each student.");
            string[][] grades = new string[5][];
            for (int i = 0; i < grades.Length; i++) {
                Console.WriteLine("Student " +(i+1)+ " grades: ");
                string studentgrades = Console.ReadLine();
                grades[i] = studentgrades.Split(" ");
            }





            Dictionary<string, string[]> categories = new Dictionary<string, string[]>();
            for (int i = 0; i < students.Length; i++) {
                    categories.Add(students[i], grades[i]);
            }

            foreach (var key in categories.Keys)
            {
                int sum = 0;
                Console.Write("Student " +key+ "'s grades: ");

                foreach (var grade in categories[key])
		        {
                    Console.Write(grade+ " ");
                    sum += Convert.ToInt32(grade);


		        }
                Console.WriteLine();
                Console.WriteLine("The highest grade is: " +categories[key].Max());
                Console.WriteLine("The lowest grade is: " +categories[key].Min());
                int avg = sum / categories[key].Length;
                Console.WriteLine("Student " +key+ "'s grade average is: " +avg);
            }
        }
    }
}
