using System;

namespace _07._NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            MatrixNxN(int.Parse(Console.ReadLine()));
        }


        /// <summary>
        /// Prints out a Matrix number form
        /// </summary>
        /// <param name="n"></param>
        static void MatrixNxN(int n)
        {
            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write(n + " ");
                }
                Console.WriteLine();

            }
        }
    }
}
