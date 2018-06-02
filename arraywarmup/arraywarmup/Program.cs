using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraywarmup
{
    class Program
    {
        static void Main(string[] args)
        {
            //17830918309183
            //3 1s,
            Console.WriteLine("Type a sentence and see how many letters are int it!");
            string sentence = Console.ReadLine().ToUpper();

            for (int i = 0; i < sentence.Length; i++)
            {
                if(sentence[i] <= 'A' + 26 && sentence[i] >= 'A')
                {
                    
                }                
            }
            //Console.WriteLine("{0}", sentence);
            //Console.ReadKey();
            int[] sSentence = new int[26];
            int wordCount = 1;
            for(int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == ' ')
                {
                    wordCount++;
                }
                else if(char.IsLetter(sentence[i]))
                {
                    int sIndex = sentence[i] - 'A';
                    sSentence[sIndex]++;
                }
            }
            for (int i = 0; i < 26; i++)
            {
                Console.WriteLine("You have {0} {1}s.", sSentence[i], (char)(i + 'A'));
            }
            Console.WriteLine("You also have {0} words in your sentence." , wordCount);




           //Example

           //int[] sLetter = new int[sentence.Length ];

           //for (int i = 0; i < sLetter.Length; i++)
           // {

           //     int index = sentence[i] - '0';
           //     sLetter[index]++;
           //  }

           // for (int i = 0; i < 10; i++)
           //  {
           //      Console.WriteLine("You have {0} {1}s.", sLetter[i], i);
           //  }
            Console.ReadKey();
        }
    }
}
