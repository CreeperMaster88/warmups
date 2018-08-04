using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8418
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello User, I will split your words by whatever character you want. Please enter the character.");
            char splitBy = char.Parse(Console.ReadLine());
            Console.WriteLine("Now write the phrase.");
            string initString = Console.ReadLine();
            int wordWereOn = 0;

            int charCount = 0;
            for(int i = 0; i < initString.Length; i++)
            {
                if(initString[i] == splitBy)
                {
                    charCount++;
                }
            }
            string[] words = new string[charCount + 1];
            for(int i = 0; i < words.Length; i++)
            {
                for(int j = wordWereOn; j < initString.Length; j++)
                {
                    if(initString[j] != splitBy)
                    {
                        words[i] += initString[j];
                        wordWereOn += 1;
                    }
                    else
                    {
                        wordWereOn++;
                        break;
                        
                    }

                }
                


            }
            for(int i = 0; i < words.Length; i++)
            {
                Console.WriteLine($"Word{i} is {words[i]}");

            }
            Console.ReadKey();
        }
    }
}
