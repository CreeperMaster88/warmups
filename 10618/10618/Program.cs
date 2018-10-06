using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10618
{
    class Program
    {
        static void Main(string[] args)
        {
            //make a 2d array of 10 by 10 random numbers between 1-50
            //ask the user for 2 numbers between 0-9
            //find that position in the array, and show it on screen
            //tell them how many numbers adjacent to this number that this number is larger than

            Console.WriteLine("Hello User, Please tell me 2 numbers between 0 and 9 (including both)");
            Console.WriteLine("First one");
            int choice1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Next one");
            int choice2 = int.Parse(Console.ReadLine());
            int[,] array = new int[10, 10];
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    array[i, j] = random.Next(1, 50);
                }
            }
            int chosenNumber = array[choice1, choice2];
            int numberOfLargerNumbers = 0;
            if (choice1 >= 0 )
            {
                if (chosenNumber < array[choice1 - 1, choice2])
                {
                    numberOfLargerNumbers++;
                }
            }
            else
            {

            }
            if (choice1 <= 9)
            {
                if (chosenNumber < array[choice1 + 1, choice2])
                {
                    numberOfLargerNumbers++;
                }
            }
            else
            {

            }
            if (choice2 >= 0)
            {
                if (chosenNumber < array[choice1 , choice2 - 1])
                {
                    numberOfLargerNumbers++;
                }
            }
            else
            {

            }
            if (choice2 <= 9)
            {
                if (chosenNumber < array[choice1, choice2 + 1])
                {
                    numberOfLargerNumbers++;
                }
            }
            else
            {

            }
            Console.WriteLine($"You chose ({choice1},{choice2}), which is {chosenNumber}. There are {numberOfLargerNumbers} larger numbers around your number.");

            Console.WriteLine("DEBUG");

            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
