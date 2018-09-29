using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _92918
{
    class Program
    {
        static void Main(string[] args)
        {
            //make 2 int arrays with 10 items filled with numbers between 1-50,
            //display them on the screen
            //tell me how many numbers in the first array are greater than the numbers in the second array in the same index
            //then tell me the largest difference seen over all and which index it was
            Console.WriteLine("Hello User, I will make 2 arrays and fill them up. I will then go on to find out how many numbers are in the first array and the largest difference between numbers.");
            int[] array1 = new int[10];
            int[] array2 = new int[10];
            int greaterArrays = 0;
            int tmp = 0;
            int greatestDifference = 0;
            int differenceArray = 0;
            Random random = new Random();
            for(int i = 0; i < 10; i++)
            {
                array1[i] = random.Next(1, 50);
                array2[i] = random.Next(1, 50);

            }
            Console.WriteLine("Here are the arrays.");
            Console.WriteLine("Array 1 is");
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(array1[i]);
            }
            Console.WriteLine("Array 2 is");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(array2[i]);
            }

            for (int i = 0; i < 10; i++)
            {
                if(array1[i] > array2[i])
                {
                    greaterArrays++;
                }
            }
            Console.WriteLine($"There are {greaterArrays} numbers in the first array that are greater than in the second array.");
            greatestDifference = array1[0] - array2[0];
            if(greatestDifference < 1)
            {
                greatestDifference *= -1;
            }
            for(int i = 0; i < 10; i++)
            {
                tmp = array1[i] - array2[i];
                if(tmp < 1)
                {
                    tmp *= -1;
                }
                if(tmp > greatestDifference)
                {
                    greatestDifference = tmp;
                    differenceArray = i;
                }


            }
            Console.WriteLine($"Index {differenceArray} has the largest difference of {greatestDifference}");
            Console.ReadKey();
        }
    }
}
