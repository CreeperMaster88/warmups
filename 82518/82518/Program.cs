using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _82518
{
    class Program
    {
        //create three functions, 1 that returns the largest number in an array, 1 that returns the smallest, and one that returns the average
        static int Largest(int[] array)
        {
            int largestNumber = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] > largestNumber)
                {
                    largestNumber = array[i];
                }
            }
            return largestNumber;
        }

        static int Smallest(int[] array)
        {
            int smallestNumber = 0;
            smallestNumber = array[0];
            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] < smallestNumber)
                {
                    smallestNumber = array[i];
                }
            }
            return smallestNumber;
        }

        static int Average(int[] array)
        {
            int averageNumber = 0;
            for(int i = 0; i < array.Length; i++)
            {
                averageNumber += array[i];
            }
            averageNumber /= array.Length;
            return averageNumber;
        }

        static void Main(string[] args)
        {
            //create an array with a size of 10
            //fill it with random numbers
            //use your functions to display the largest numbers, smallest number, and the average
            int[] randomArray = new int[10];
            Random random = new Random();
            for(int i = 0; i < randomArray.Length; i++)
            {
                randomArray[i] = random.Next(1, 999);
            }
            int small = Smallest(randomArray);
            int avg = Average(randomArray);
            int large = Largest(randomArray);
            Console.WriteLine("Hello User, I just did a ton of math and I will tell you the lowest number, the highest number, and the average of a 10 number array with numbers ranging from 1 to 999");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine($"The smallest number is {small}.");
            Console.ReadKey();
            Console.WriteLine($"The average is {avg}.");
            Console.ReadKey();
            Console.WriteLine($"The largest number is... {large}.");
            Console.ReadKey();
        }
    }
}
