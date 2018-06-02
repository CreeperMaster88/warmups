using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warmup2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask the user how many numbers they are going to enter
            //create an array of that size
            //have the user add numbers to the array
            //tell the user the largest number and the smallest number from what they entered
            Console.WriteLine("Hello. Please enter the amount of numbers you want.");
            int arrayNumber = int.Parse(Console.ReadLine());
            int smallNumber = 0;
            int bigNumber = 0;
            int[] numbers = new int[arrayNumber];
            for(int i = 0; i < arrayNumber; i++)
            {
                Console.WriteLine("Please enter number {0}", i + 1);
                numbers[i] = int.Parse(Console.ReadLine());    
            }
            for(int i = 0; i < arrayNumber; i++)
            {
                if (i == 0)
                {
                    bigNumber = numbers[0];
                    smallNumber = bigNumber;
                }
                if (numbers[i] > bigNumber)
                {
                    bigNumber = numbers[i];
                }
                else if(numbers[i] < smallNumber)
                {
                    smallNumber = numbers[i];
                }



            }
                Console.WriteLine("Alright. The smallest number is {0}, and the largest number is {1}. :) Hoped you got your answer!" , smallNumber, bigNumber);
            Console.ReadKey();
        }
    }
}
