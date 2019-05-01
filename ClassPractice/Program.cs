using System;

namespace ClassPractice
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    class Person
    {
        public char gender;
        public string name;

        public Person(bool chooseGender) {
            if (chooseGender) {
                this.name = "Jane Doe";
                this.gender = 'F';
            }else {
                this.name = "John Doe";
                this.gender = 'M';
            }
        }
    }
}
