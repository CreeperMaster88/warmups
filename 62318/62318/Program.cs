using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _62318
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask the user for a word
            //create 2 arrays
            //store all vowels of the word in one array and all consonants in the other array
            //display the contents of these arrays
            Console.WriteLine("Hello __USER__, Please enter a sentence or string of sentences and I will seperate the vowels from the consonanats");
            string inputText = Console.ReadLine();
            string inputTextU = inputText.ToUpper();
            string siftedText = "";
            int consonants = 0;
            int vowels = 0;
            string vowel = "";
            string consonant = "";

            for (int i = 0; i < inputTextU.Length; i++)
            {
                if (inputTextU[i] >= 65 && inputTextU[i] <= 90)
                {
                    siftedText += inputTextU[i];
                }
            }
            for (int i = 0; i < siftedText.Length; i++)
            {
                if (siftedText[i] == 'A' || siftedText[i] == 'E' || siftedText[i] == 'I' || siftedText[i] == 'O' || siftedText[i] == 'U' || siftedText[i] == 'Y')
                {
                    vowels++;
                    vowel += siftedText[i];
                }
                else
                {
                    consonants++;
                    consonant += siftedText[i];
                }
            }
            Console.WriteLine($"Your original string was {inputText}, then it became {inputTextU}, then it was filtered to {siftedText}, and finally, you have {consonants} consonants ({consonant}) and {vowels} vowels ({vowel}).");
            Console.ReadKey();
        }
    }
}
