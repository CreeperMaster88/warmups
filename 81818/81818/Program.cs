using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _81818
{
    class Program
    {
        //take in an array to search through
        //take in an item to search for
        //search the array for the item
        //if it is there return true. if not return false
        static bool Contains(int[] numbers, int searchFor)
        {
            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == searchFor)
                {
                    return true;
                }

            }

            return false;
        }

        //create an array and fill it with random numbers
        //ask the user to enter a number to check for
        //tell the user whether the array contains the number or not
        static void Main(string[] args)
        {
            Console.WriteLine("Hello user, I will produce a random array with numbers between 1 and 100, and you can ask if a number is in there or not.");
            Random gen = new Random();
            int[] numbers = new int[gen.Next(20,100)];
            Console.WriteLine("What number do you want to look for between 0 and 100?");
            int guess = int.Parse(Console.ReadLine());

            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] += gen.Next(0, 100);
            }

            if (Contains(numbers, guess))
            {
                Console.WriteLine($"Guess What? {guess} is in there! Good Job.");
            }
            else
            {
                Console.WriteLine($"Sorry. {guess} doesn't exist in the array.");
            }
            Console.ReadKey();
        }
    }
}
