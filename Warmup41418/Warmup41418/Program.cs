using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warmup41418
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello User, Please type a sentence and I will tell you the largest word in that sentence. ");
            string sentence = Console.ReadLine();

            string tempWord = "";
            string LongestWord = "";
            int sentences = 1;

            int longestSentence;
            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] != ' ')
                {
                    tempWord += sentence[i];
                }
                else
                {
                    if (tempWord.Length > LongestWord.Length)
                    {
                        LongestWord = tempWord;
                    }
                    tempWord = "";
                }
            }
            if (tempWord.Length > LongestWord.Length)
            {
                LongestWord = tempWord;
            }
            tempWord = "";
            longestSentence = LongestWord.Length;
            Console.WriteLine("The longest word is {0} and has {1} letters.", LongestWord, longestSentence);
            Console.ReadKey();

        }
    }
}
