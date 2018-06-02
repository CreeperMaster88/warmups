using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_5_18
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask the user for a string
            //reprint the string but replace all of the letters
            //E = 3
            //A = 4
            //O = 0
            //S = 5
            Console.WriteLine("Hello, User, Please type in a long sentence. PLEASE");
            string sentence = Console.ReadLine();
            string sentenceTmp = sentence.ToLower();
            string newSentence = "";
            int whichOne = 0;
            bool changeIt = false;
            string letters = "eaos";
            string replacements = "3405";
            for(int i = 0; i < sentenceTmp.Length; i++)
            {
                for (int j = 0; j < letters.Length; j++)
                {
                    if(sentenceTmp[i] == letters[j])
                    {
                        changeIt = true;
                        whichOne = j;
                    }
                    
                    
                }
                if (changeIt)
                {
                    newSentence += replacements[whichOne];
                    
                }
                else
                {
                    newSentence += sentence[i];
                }
                changeIt = false;

            }
            Console.WriteLine("4lright! Y0ur v4nd4liz3d 53nt3nc3 i5 {0} ", newSentence);
            Console.ReadKey();


        }
    }
}
