using System;

namespace Checkpoint1
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            for(int i = 0; i < 101; i++) {
                if (i % 3 == 0) {
                    Console.WriteLine(i);
                    count++;
                }
            }
            Console.WriteLine("The count of numbers divisible by 3 is: " +count);

            string answer = " ";
            int sum = 0;
            while (answer != "ok") {
                Console.WriteLine("Enter a number or 'ok' to exit: ");
                answer = Console.ReadLine();
                if(answer == "ok") {
                    break;
                }
                sum += Convert.ToInt32(answer);
            }
            Console.WriteLine("The sum of the entered numbers is: " +sum);

            int total = 1;
            Console.WriteLine("Please enter a number: ");
            string num = Console.ReadLine();
            int intNum = Convert.ToInt32(num);
            for (int i = intNum; i > 0; i--) {
                total *= i;
            }
            Console.WriteLine(intNum+ "! = " +total);



        }

    }
}
