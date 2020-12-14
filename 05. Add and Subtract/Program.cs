using System;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputOne = 0;
            int inputTwo = 0;
            int inputThree = 0;

           Console.WriteLine( Sum(inputOne, inputTwo) - Subtract(inputThree));

           
        }
        /// <summary>
        /// Adds the first two input together
        /// </summary>
        /// <param name="one"></param>
        /// <param name="two"></param>
        /// <returns></returns>
        static int Sum(int one, int two)
        {
            one = int.Parse(Console.ReadLine());
            two = int.Parse(Console.ReadLine());
            return one + two;

        }

        /// <summary>
        /// Subtracts itself of a sum
        /// </summary>
        /// <param name="one"></param>
        /// <returns></returns>
        static int Subtract(int input)
        {
            input = int.Parse(Console.ReadLine());
            return input;
        }
    }
}
