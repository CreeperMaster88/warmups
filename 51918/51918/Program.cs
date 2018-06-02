using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _51918
{
    class Program
    {
        static void Main(string[] args)
        {
            //the user enters two words
            //check if the words are anagrams of each other 
            //tell the user if they are or not

            //lives
            //elvis
           
            Console.WriteLine("Hello user, You will be asked to type in two words and i will see if they are Anagrams or not.");
            Console.WriteLine("Please enter the first word.");
            int sameLetters = 0;
            string firstWord = Console.ReadLine().ToLower();
            Console.WriteLine("Now the second.");
            string secondWord = Console.ReadLine().ToLower();
            while (true)
            {
                if (firstWord == secondWord)
                {
                    Console.WriteLine("Hey! That's the same word!");
                    break;
                }
                else if (firstWord.Length != secondWord.Length)
                {
                    Console.WriteLine("The words are different lengths. No way are they the same!");
                    break;
                }
                for (int i = 0; i < firstWord.Length; i++)
                {
                    for (int j = 0; j < secondWord.Length; j++)
                    {
                        if(firstWord[i] == secondWord[j])
                        {
                            sameLetters++;
                        }
                    }
                }
                 if (firstWord.Length == sameLetters)
                {
                    Console.WriteLine($"Yay! {firstWord} and {secondWord} are Anagrams!");
                    break;
                }
                 else
                {
                    Console.WriteLine($"Sorry. {firstWord} and {secondWord} aren't Anagrams.");
                    break;
                }
            }
            Console.ReadKey();
            
        }
    }
}
