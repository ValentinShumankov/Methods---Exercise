using System;
using System.Linq;

namespace _06._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            MiddleChar(Console.ReadLine());
        }
        
        static void MiddleChar(string input)
        {
            
            if (input.Length % 2 == 0)
            {
                Console.Write(input[(input.Length / 2)-1].ToString());
                Console.Write(input[input.Length / 2].ToString());
                
            }
            else
            {
                Console.WriteLine(input[(input.Length / 2)].ToString());

            }
        }
    }
}
