using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7718
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an array with a random size between 3 and 7
            //fill the array with random numbers from 0-9
            //each number must be unique
            //have the user guess one of the unique numbers

            Console.WriteLine("Hello User, I will make random numbers and you need to guess them.");
            Random numGen = new Random();
            int[] randNums = new int[numGen.Next(3,7)];
            int tmp = 0;
            bool isCorrect = false;
            bool addedRandom = false;
            bool isUnique = false ;
            for(int i = 0; i < randNums.Length; i++)
            {
                
                while (!isUnique)
                {
                    isUnique = true;

                    tmp = numGen.Next(0, 9);
                    for (int j = 0; j < randNums.Length; j++)
                    {
                        if (tmp == randNums[j])
                        {
                            isUnique = false;
                        }

                    }

                        
                        

                    
                }
                isUnique = false;
                randNums[i] = tmp;


            }
            Console.WriteLine("You have one guess/ Go ahead. Enter a number between 0 and 9.");
            int userNumber = int.Parse(Console.ReadLine());
            for(int i = 0; i < randNums.Length; i++)
            {
                if(userNumber == randNums[i])
                {
                    isCorrect = true;
                }
               
                Console.WriteLine($"{randNums[i]}");

            }
            if (isCorrect)
            {
                Console.WriteLine($"Good Job! {userNumber} is correct!");
            }
            else
            {
                Console.WriteLine($"Sorry, {userNumber} is incorrect.");
            }
            Console.ReadKey();



        }
    }
}
