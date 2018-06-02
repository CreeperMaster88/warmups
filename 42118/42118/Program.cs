using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42118
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask the user for a word
            //tell them if the word is a palindrome or not
            Console.WriteLine("Hello, Please give me a word and I'll tell if it's a palindrome or not.");
            string palindrome = Console.ReadLine();
            int tmp1 = palindrome.Length;
            int tmp2 = tmp1 / 2;
            int pChecker = 0;
            string fixedPalindrome = "";
            Console.WriteLine("{0}", tmp2);
            Console.ReadKey();
            for(int i = 0; i < palindrome.Length; i++)
            {
                if(palindrome[i] != ' ')
                {
                    fixedPalindrome += palindrome[i];
                }
            }
            for (int i = 0; i < tmp2; i++)
            {
                if (fixedPalindrome[i] == fixedPalindrome[fixedPalindrome.Length - (i + 1)])
                {
                    pChecker++;
                }
            }
            if(tmp2 == pChecker)
            {
                Console.WriteLine("{0} is a Palindrome!!!", palindrome);
            }
            else
            {
                Console.WriteLine("Sorry, {0} isn't a palindrome.", palindrome);
            }
            Console.ReadKey();
        }
    }
}
