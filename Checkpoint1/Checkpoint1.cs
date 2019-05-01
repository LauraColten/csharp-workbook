using System;
using System.Linq;

namespace Checkpoint1
{
  class Program
  {

    static void Main(string[] args)
    {
      Divisible(" ");
      Sum(" ");
      Factor(" ");
      Random(" ");
      MinMax(" ");

    }


    //This function divides 100 by user input to see how many numbers the chosen number divides into evenly.
    static int Divisible(string divide) {
     Console.WriteLine("Enter a number to divide by: ");
     int divisor = Convert.ToInt32(Console.ReadLine());
     int count = 0;
      for (int i = 0; i < 101; i++)
      {
        if (i % divisor == 0)
        {
          Console.WriteLine(i);
          count++;
        }
      }
      Console.WriteLine("The count of numbers divisible by " +divisor+ " is: " + count);
     return divisor;
   }
  //This function takes in numbers from a user and returns the sum.
   static int Sum(string stringAnswer) {
      string answer = " ";
      int sum = 0;
      while (answer != "ok")
      {
        Console.WriteLine("Enter a number or 'ok' to exit: ");
        answer = Console.ReadLine();
        if (answer == "ok")
        {
          break;
        }
        sum += Convert.ToInt32(answer);
      }
      Console.WriteLine("The sum of the entered numbers is: " + sum);
      return sum;
    }

  //This function takes in a number from the user and factors it.
    static int Factor(string factorNum) {
      int total = 1;
      Console.WriteLine("Please enter a number: ");
      string num = Console.ReadLine();
      int intNum = Convert.ToInt32(num);
      for (int i = intNum; i > 0; i--)
      {
        total *= i;
      }
      Console.WriteLine(intNum + "! = " + total);
      return total;
    }

  //This function takes in a series of numbers from a user and has them try to guess the random number generated.
    static int Random(string numberGuess) {
      Random random = new Random();
      int number = random.Next(10);
      for (int i = 0; i < 4; i++)
      {
        Console.WriteLine("Guess any positive number less than 10: ");
        int guess = Convert.ToInt32(Console.ReadLine());
        if (guess == number)
        {
          Console.WriteLine("You won! The number was: " + number);
          break;

        }
        else if (guess != number && i == 3)
        {
          Console.WriteLine("Sorry, you lost! The number was: " + number);
        }
        else
        {
          if (guess != number)
          {
            Console.WriteLine("Sorry, that's not the number. Guess again:");
          }
        }
      }
      return number;
    }

  //This function takes in a series of numbers from the user and returns the max and the min.
    static int [] MinMax(string hiLoNumbers) {
      Console.WriteLine("Please enter 5 numbers separated by commas: ");
      string userInput = Console.ReadLine();
      string[] splitInput = userInput.Split(',');
      int[] intArray = new int[5];
      for (int i = 0; i < splitInput.Length; i++)
      {
        intArray[i] = Convert.ToInt32(splitInput[i]);
      }
      int max = intArray.Max();
      int min = intArray.Min();
      Console.WriteLine("The highest number is: " + max);
      Console.WriteLine("The lowest number is: " + min);
      return new int [] {max, min};
    }


  }
}
