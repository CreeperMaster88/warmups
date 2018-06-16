using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6918
{
    class Program
    {
        static void Main(string[] args)
        {
            //create two arrays with random sizes between 3 and 10
            //fill them with random numbers
            //add each index of each array to each other and store the sums into a third array
            //array1[0] + array2[0] = array3[0]
            Random arraySizer = new Random();
            Random numberMaker = new Random();
            int[] longArray;
            int[] shortArray;

            int[] firstSet = new int[arraySizer.Next(3, 10)];
            int[] secondSet = new int[arraySizer.Next(3, 10)];
            if (firstSet.Length > secondSet.Length)
            {
                longArray = new int[firstSet.Length];

                shortArray = new int[secondSet.Length];

            }
            else
            {
                longArray = new int[secondSet.Length];

                shortArray = new int[firstSet.Length];

            }
            int[] thirdSet = new int[longArray.Length];
           
            int total = 0;
            for(int i = 0; i <longArray.Length; i++)
            {
                longArray[i] = numberMaker.Next(0, 20);
            }
            for(int i = 0; i < shortArray.Length; i++)
            {
                shortArray[i] = numberMaker.Next(0, 20);
            }

            for (int i = 0; i < shortArray.Length; i++)
            {
                thirdSet[i] = longArray[i] + shortArray[i];
            }
            for(int i = shortArray.Length; i < longArray.Length; i++)
            {
                thirdSet[i] = longArray[i];
            }
            Console.WriteLine("Hello User, I have added up two random arrays and will give all outputs and then the grand sum.");
            Console.WriteLine("First set is...");
            Console.ReadKey();
            for (int i = 0; i < longArray.Length; i++)
            {
                Console.WriteLine($"{longArray[i]}");
            }
            Console.ReadKey();
            Console.WriteLine("second set is...");
            Console.ReadKey();
            for (int i = 0; i < shortArray.Length; i++)
            {
                Console.WriteLine($"{shortArray[i]}");
            }
            Console.ReadKey();
            Console.WriteLine("added set is...");
            Console.ReadKey();
            for (int i = 0; i < longArray.Length; i++)
            {
                Console.WriteLine($"{thirdSet[i]}");
            }

            Console.ReadKey();
            Console.WriteLine("The grand sum is...");
            Console.ReadKey();
            for (int i = 0; i < longArray.Length; i++)
            {
                total += thirdSet[i];
            }
            Console.WriteLine($"{total}");
            Console.ReadKey();
        }
    }
}
