using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _71418
{
    class Program
    {
        static void Main(string[] args)
        {
            //make an array of 5 numbers
            //then store 5 random numbers into the array
            //then sort them from least to greatest
            int[] baseArray = new int[5];
            int temp = 0;
            int[] tmp = new int[5];
            Random random = new Random();
            for(int i = 0; i < baseArray.Length; i++)
            {
                baseArray[i] = random.Next(0, 100);
                Console.WriteLine($"{baseArray[i]}");

            }
            

            for(int i = 0; i < baseArray.Length; i++)
            {
                for(int j = 0; j < baseArray.Length; j++)
                {
                  if(baseArray[i] < baseArray[j])
                    {
                        temp = baseArray[j];
                        baseArray[j] = baseArray[i];
                        baseArray[i] = temp;
                        temp = 0;
                    }

                }
                
            }

            Console.WriteLine("Then...");
            for (int i = 0; i < baseArray.Length; i++)
            {
                Console.WriteLine($"{baseArray[i]}");
            }
            Console.ReadKey();
            

        }
    }
}
