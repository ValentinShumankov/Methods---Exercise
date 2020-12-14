using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            Factorial(num1,num2);
        }


        /// <summary>
        /// Factorial Division,devides factorial of num1 by factorial of num2.
        /// </summary>
        /// <param name="one"></param>
        /// <param name="two"></param>
        static void Factorial(int one, int two)
        {
            double sumOne = one;
            double sumTwo = two;
            for (int i = one - 1; i > 0; i--)
            {
                sumOne *= i;
            }

            for (int i = two - 1; i > 0; i--)
            {
                sumTwo *= i;
            }

            double result = sumOne / sumTwo;
           
            Console.WriteLine($"{result:f2}");
        }
    }
}
