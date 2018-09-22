using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _92218
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask the user for a word, tell them which letter is most common, if there is a tie go with the alphabetical order
            Console.WriteLine("Hello User, Please enter a word or phrase and I will tell you the most common letter.");
            string userText = Console.ReadLine().ToUpper();
            int highestNumber = 0;

            int mostCommon = 0;
            int[] numberOfCharacters = new int[26];


            for(int i = 0; i < userText.Length; i++)
            {
                numberOfCharacters[userText[i] - 65] += 1;
            }
            highestNumber = numberOfCharacters[0];
            for (int i = 0; i < numberOfCharacters.Length; i++)
            {

                if (numberOfCharacters[i] > highestNumber)
                {
                    highestNumber = numberOfCharacters[i];
                }
            }
            for(int i = 0; i < numberOfCharacters.Length; i++)
            {
                if(numberOfCharacters[i] == highestNumber)
                {
                    mostCommon = i;
                }
            }
            mostCommon += 65;
            Console.Write((char)mostCommon);
            Console.Write(" is the most common character. ");
            Console.WriteLine($"It appears {numberOfCharacters[mostCommon - 65]} times.");
            Console.ReadKey();

        }
    }
}
