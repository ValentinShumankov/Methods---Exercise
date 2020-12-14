using System;
using System.Xml.Serialization;

namespace _01._Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            SmallesDigit(a, b, c);

        }

        /// <summary>
        /// Determines the smalles value digit
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        static void SmallesDigit(int a ,int b, int c)
        {
            int[] nums = { a, b, c };
            Array.Sort(nums);
            Console.WriteLine(nums[0]);
        }
    }
}
