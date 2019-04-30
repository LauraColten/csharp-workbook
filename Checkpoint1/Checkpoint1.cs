using System;
using System.Linq;

namespace Checkpoint1
{
  class Program
  {
    static void Main(string[] args)
    {
      int count = 0;
      for (int i = 0; i < 101; i++)
      {
        if (i % 3 == 0)
        {
          Console.WriteLine(i);
          count++;
        }
      }
      Console.WriteLine("The count of numbers divisible by 3 is: " + count);

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

      int total = 1;
      Console.WriteLine("Please enter a number: ");
      string num = Console.ReadLine();
      int intNum = Convert.ToInt32(num);
      for (int i = intNum; i > 0; i--)
      {
        total *= i;
      }
      Console.WriteLine(intNum + "! = " + total);

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
          if (guess != number && i == 3)
          {
            Console.WriteLine("Sorry, you lost! The number was: " + number);
          }
        }
      }

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

    }

  }
}
