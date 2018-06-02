using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42818
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              ask the user to enter a string
              ask the user to choose a character in the string and what character they want to replace it with
              swap the two characters
             */
            Console.WriteLine("Hello User, Type in a word or phrase.");
            int correctLetter = 0;
            int whereIsLetter = 0;
            string newPhrase = "";
            string phrase = Console.ReadLine();


            
  
                
                
                    Console.WriteLine("What letter do you want to change?");
                    char letterToChange = Console.ReadLine()[0];
                    Console.WriteLine("What do you want to replace it with?");
                    string changeLetter = Console.ReadLine();



                        for (int i = 0; i < phrase.Length; i++)
                        {



                            if (letterToChange == phrase[i])
                            {
                                correctLetter++;
                            }
                            else if (correctLetter == 0)
                            {
                                whereIsLetter++;
                                //whereIsLetter + 1 is that letter
                            }

                        }
              
                    for(int i = 0; i < phrase.Length; i++)
                    {
                        if(phrase[i] == letterToChange)
                        {
                            newPhrase += changeLetter;
                        }
                        else
                        {
                            newPhrase += phrase[i];
                        }
                    }
                    Console.WriteLine("Alrighty! Your word is {0}. ", newPhrase);
                   


            
            Console.ReadKey();

        }
    }
}
