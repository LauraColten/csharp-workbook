using System;

namespace ScopesExercise
{
    class Program
    {
        static void Main(string[] args)
        {   int sum = 0;
            for (int i = 0; i <= 100; i++) {
                sum = sum + i;
            }
            Console.WriteLine(sum);

            int sum2 = 0;
            int i2 = 1;
            while(i2 <= 100) {
                sum2 = sum2 + i2;
                i2++;
            }
            Console.WriteLine(sum2);

            int sum3 = 0;
            int i3 = 1;
            do {
                sum3 = sum3 + i3;
                i3++;
            }while(i3 <= 100);
            Console.WriteLine(sum3);



            Sum(5, 6);
            Product(2, 4);
        }

        static int Sum(int num1, int num2) {
            int sum = num1 + num2;
            Console.WriteLine("inside sum " +num1);
            Console.WriteLine("inside sum " +num2);
            Console.WriteLine("sum = " +sum);
            return sum;
        }

        static int Product(int num1, int num2) {
            int product = num1 * num2;
            Console.WriteLine("inside product " +num1);
            Console.WriteLine("inside product " +num2);
            Console.WriteLine("product = " +product);
            return product;
        }
    }
}
