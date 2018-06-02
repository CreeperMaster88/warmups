using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_12_18
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask the user to enter any text
            //then ask them how many words they want to add onto this text
            //then store each word the user wants to enter into an array of words
            //then make a function called Combine that accepts the original text, and the array of new words
            //then use this to give you back new text with the words added on
            
            Console.WriteLine("Hello user, Please type in some incomplete text.");
            string unfinishedText = Console.ReadLine();
            unfinishedText += ' ';
            Console.WriteLine("Now enter words and everytime you do, hit Enter. When you are done, type 'END'.");
            Console.WriteLine("How many words do you want to add to the text? You can always add less if you want.");
            int numberOfWords = int.Parse(Console.ReadLine());
            string finishedText = "";
            Console.WriteLine("Start Typing!");
            string[] words = new string[numberOfWords];
            string tmp = "";
            int wordsLeft = 0;
            for (int i = 0; i < words.Length; i++)
                {
                wordsLeft = words.Length - i;
                    Console.WriteLine($"You have {wordsLeft} words left.");
                tmp = Console.ReadLine();
                    if (tmp == "END")
                    {
                    i = words.Length;
                    }
                    else
                    {
                    words[i] += tmp;
                    }
                }
            finishedText += unfinishedText;
            for(int i = 0; i < words.Length; i++)
            {
                finishedText += words[i];
                finishedText += ' ';
            }
            Console.WriteLine($"Your finished text is {finishedText} Thank's for using Text Fixer!");
            Console.ReadKey();
            

        }
    }
}
