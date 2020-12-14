using System;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            VowelCounter(Console.ReadLine().ToLower());
        }

        /// <summary>
        /// Counts out the vowels in the sentence.
        /// </summary>
        /// <param name="sentence"></param>
        static void VowelCounter(string sentence)
        {
            int total = 0;
            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == 'a' || sentence[i] == 'e' || 
                    sentence[i] == 'i' || sentence[i] == 'o' || 
                    sentence[i] == 'u')
                {
                    total++;
                }
            }
            Console.WriteLine(total);
        }
    }
}
