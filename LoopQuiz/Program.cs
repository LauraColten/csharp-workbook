using System;
using System.Linq;

namespace LoopQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myIntArray = {2, 5, 18, 22, 10};

            //Finding largest using Max
            int max = myIntArray.Max();

            //Finding smallest using Min
            int min = myIntArray.Min();
            Console.WriteLine(max);
            Console.WriteLine(min);

            //Finding largest with a for loop
            int soFar = myIntArray[0];
            for(int i = 0; i < myIntArray.Length; i++) {
                int currentNumber = myIntArray[i];
                if(currentNumber > soFar) {
                    soFar = currentNumber;
                }
            }
            Console.WriteLine(soFar);

            //Finding the sum
            int sum = 0;
            for(int i = 0; i < myIntArray.Length; i++) {
                sum += myIntArray[i];
            }
            Console.WriteLine(sum);

        }
    }
}
