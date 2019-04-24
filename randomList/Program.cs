using System;
using System.Collections.Generic;


namespace randomList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> students = new List<string>();
            students.Add("Andy");
            students.Add("Austin");
            students.Add("Laura");
            students.Add("Alysia");
            students.Add("Jazon");
            students.Add("David");
            students.Add("Jungil");
            students.Add("Gannon");
            students.Add("Chase");

            List<string> randomOrder = randomize(students);

            foreach(string student in randomOrder) {
                Console.WriteLine(student);
            }
        }

        static List<string> randomize(List<string> originalList) {
            Random random = new Random();
            for (int i = originalList.Count; i > 0; i--) {
                int r = random.Next(0, originalList.Count - 1);
                string temp = originalList[r];
                originalList.RemoveAt(r);
                originalList.Add(temp);
            }
            return originalList;
        }
    }
}

