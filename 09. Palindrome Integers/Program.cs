using System;
using System.Linq;
using System.Security.Cryptography;

namespace _09._Palindrome_Integers
{
    class Program
    {
        public static object StringHelper { get; private set; }

        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            while (command != "END")
            {
                Console.WriteLine(Palindrome(command));

                command = Console.ReadLine();
            };
        }
       
        /// <summary>
        /// Palindrome: Compares if the sum i exactly the same if read in both directions.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>

        static string Palindrome(string nums)
        {
            string reversed = ReverseString(nums);
            int n = nums.CompareTo(reversed);
            if(n == 0)
            {
                return "true";
            }
            else
            {
                return "false";
            }
        }


        /// <summary>
        /// Receives string and returns the string with its letters reversed.
        /// </summary>
        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

    }

}
