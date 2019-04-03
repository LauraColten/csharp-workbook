using System;

namespace IntroPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Find the sum of two numbers.
            Console.WriteLine("Please enter a number: ");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter another number: ");
            int numberTwo = Convert.ToInt32(Console.ReadLine());
            int sum = numberOne + numberTwo;
            Console.WriteLine("The sum of your numbers is: "+sum);

            //Convert yards to inches.
            Console.WriteLine("Enter a measurement in yards: ");
            int yards = Convert.ToInt32(Console.ReadLine());
            int inches = yards * 36;
            Console.WriteLine("That converts to " +inches+ " inches.");

            //Define variables.
            bool people = true;
            bool f = false;
            decimal num = 9.9m;
            decimal product = num * num;
            string firstName = "Laura";
            string lastName = "Colten";
            int age = 34;
            string job = "student";
            string favoriteBand = "The Beatles";
            string favoriteSportsTeam = "The Dallas Cowboys";

            //Experiment with Console.Writeline().
            Console.WriteLine("Hello, my name is " +firstName +" " +lastName+ ", and I am " +age+ " years old.");
            Console.WriteLine("I am a " +job+ ".");
            Console.WriteLine("My favorite band is " +favoriteBand+ ", and I love " +favoriteSportsTeam+ ".");

            //Convert num to an int.
            decimal NewNum = Convert.ToInt32(num);
            Console.WriteLine(NewNum);

            //Math with 10 and 100.
            int num1 = 10;
            int num2 = 100;
            int newSum = num1 + num2;
            Console.WriteLine(newSum);

            int newProduct = num1 * num2;
            Console.WriteLine(newProduct);

            int difference = num2 - num1;
            Console.WriteLine(difference);

            int quotient = num2 / num1;
            Console.WriteLine(quotient);


        }
    }
}
