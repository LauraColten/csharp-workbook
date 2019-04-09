using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plese enter a number: ");
            int userNum = Convert.ToInt32(Console.ReadLine());
            if (userNum > 0) {
                Console.WriteLine("Your number is positive.");
            }else {
                Console.WriteLine("Your number is negative.");
            }
            }

        }
    }

