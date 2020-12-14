using System;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace _11._Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {

            int count = 0;
            int[] array = stringToArrayDigits(Console.ReadLine());
            string input = Console.ReadLine();
            int[] arrayMain = new int[array.Length];
            while (input != "end")
            {
                StringBuilder command = new StringBuilder();
                //bool isIntString = input.All(char.IsDigit);
                
                bool isDigitPresent = input.Any(c => char.IsDigit(c));

                if (isDigitPresent)
                {
                    count = int.Parse(intSeparetor(input));

                }
                string phrase = input;
                string[] words = phrase.Split(' ', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0');
                foreach (var word in words)
                {
                    command.Append(word);
                }
                if (command.ToString() == "exchange")
                {

                    if (count > array.Length)
                    {
                        Console.WriteLine("Invalid index");

                    }
                    else
                    {
                        arrayMain = exchangeIndex(array, count);
                        for (int i = 0; i < arrayMain.Length; i++)
                        {
                            Console.Write((char)arrayMain[i] + " ");
                        }
                    }
                    Console.WriteLine();

                }
                else if (command.ToString() == "maxodd")
                {
                    MaxOdd(arrayMain);
                }

                input = Console.ReadLine();
            }

        }



        static void MaxOdd(int[] input)
        {
            int evenCounter = 0;
            int[] odds = new int[input.Length];
           
            int lowestDigit = odds.Min();
            
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] % 2 != 0)
                {
                    if (input[i] > lowestDigit)
                    {
                        lowestDigit = i;

                    }
                }
                else
                {
                    evenCounter++;
                    if (evenCounter == input.Length)
                    {
                        Console.WriteLine("No matches");
                    }
                }
            }
            if(evenCounter < input.Length)
            {
                Console.WriteLine(lowestDigit);
            }
          
        }



        /// <summary>
        /// Rotates the Array in antyclockwise fashion
        /// </summary>
        /// <param name="input"></param>
        /// <param name="numRepetitions"></param>
        /// <returns></returns>
        static int[] exchangeIndex(int[] input, int numRepetitions = 0)
        {

            int[] nums = input;
            for (int i = 0; i <= numRepetitions; i++)
            {
                var temp = nums[0];
                for (var j = 0; j < nums.Length - 1; j++)
                {
                    nums[j] = nums[j + 1];
                }
                nums[nums.Length - 1] = temp;

            }

            return nums;
        }







        /// <summary>
        /// Converts a string to just row of digits and convert them to an Array.
        /// Returns Array.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        static int[] stringToArrayDigits(string input)
        {

            

            int[] numsArray = new int[intSeparetor(input).Length];
            for (int i = 0; i < intSeparetor(input).Length; i++)
            {
                numsArray[i] = char.Parse(intSeparetor(input)[i].ToString());
                
            }


            return numsArray;

        }

        /// <summary>
        /// Separates all but the digit from a string .
        /// Retursn String whit just the digits.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        static string intSeparetor(string input)
        {

            string nums = new String(input.Where(Char.IsDigit).ToArray());

            return nums;

        }

    }
}
