using System;

namespace RockPaperScissors
{
  class Program
  {
    public static void Main()
    {
      Console.WriteLine("Let's play rock, paper, scissors!");
      Console.WriteLine("Enter r, p, or s");
      string hand1 = Console.ReadLine().ToLower();
      if (hand1 != "r" || hand1 != "p" || hand1 != "s")
      {
        throw new Exception("Not a valid hand entry");
      }

      Console.WriteLine("The computer is choosing...");
      string newChoice = computerChoice();
      Console.WriteLine(newChoice);
      Console.WriteLine(CompareHands(hand1, newChoice));

    }


    public static string computerChoice()
    {
      Random generator = new Random();
      int randomNumber = generator.Next(0, 3);
      string numToString = randomNumber.ToString();
      if (numToString == "0")
      {
        return "r";
      }
      else if (numToString == "1")
      {
        return "p";
      }
      else
      {
        return "s";
      }

    }
    public static string CompareHands(string hand1, string hand2)
    {
        if (hand1 == hand2)
        {
          return "It's a tie!";
        }
        else if (hand1 == "r" && hand2 == "s")
        {
          return "You win!";
        }
        else if (hand1 == "s" && hand2 == "p")
        {
          return "You win!";
        }
        else if (hand1 == "p" && hand2 == "r")
        {
          return "You win!";
        }
        else
        {
          return "The computer wins!";
        }
      }
    }
    public class MyException : System.Exception
    {
      public MyException() { }
      public MyException(string message) : base(message) { }
      public MyException(string message, System.Exception inner) : base(message, inner) { }
      protected MyException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
  }


