using System;

namespace _03._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            CharactersInRange(a, b);
        }

        static void CharactersInRange(char a, char b)
        {
            int firstChar = Math.Min(a,b);
            int secondChar = Math.Max(a,b);
          
            for (int i = ++firstChar; i < secondChar; i++)
            {
                Console.Write((char)i + " ");
            }
            Console.WriteLine();
        }
    }
}
