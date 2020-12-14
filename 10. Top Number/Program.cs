using System;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            TopNumber(int.Parse(Console.ReadLine()));
        }


        /// <summary>
        /// Determines all top numbers / Prints Out Result.
        /// </summary>
        /// <param name="num"></param>
        static void TopNumber(int num)
        {
            bool devisibleBy8 = false;
            bool oddDigit = false;
            for (int i = 0; i < num; i++)
            {
                devisibleBy8 = false;
                oddDigit = false;
                int digitSum = 0;
                int number = i;
               
                while (number > 0)
                {
                    digitSum += number % 10;
                    number /= 10;
                }
               
              
                if (digitSum % 8 == 0)
                {
                    devisibleBy8 = true;
                    string tempor = i.ToString();
                    for (int j = 0; j < tempor.Length; j++)
                    {
                        if (tempor[j] % 2 == 1)
                        {
                            oddDigit = true;
                        }

                    }
                }
              
                if (devisibleBy8 == true)
                {
                    if (oddDigit == true)
                    {
                        Console.WriteLine(i);

                    }
                }

            }
        }
    }
}
