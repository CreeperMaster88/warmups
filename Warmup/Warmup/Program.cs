using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warmup
{
    
    class Program
    {
        
        // Randomly generate an array of 10 numbers (0-9)
        // How many of each number are in the array
        // What is the average of the array
        static void Main(string[] args)
        {
            Random arrayGenerator = new Random();
            int[] randoms = new int[10];
            int[] tmp = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] count = new int[10];
            float avg = 0;
            int helper = 0;
            
            for(int i=0; i < 10; i++)
            {
                randoms[i] = arrayGenerator.Next(0, 9);
                Console.Write("{0}", randoms[i]);
                //tmp[i] = randoms[i];
            }
            for(int i = 0; i < 10; i++)
            {
                avg += randoms[i];
                for (int j = 0; j < 10; j++)
                {
                    if(randoms[i] == tmp[j])
                    {
                        count[j]++;
                        
                    }
                }

                helper++;
            }
            for (int i  = 0; i < 10; i++)
            {
                Console.WriteLine(" there are {0} {1}s.", count[i], tmp[i]);
            }
            avg /= 10;
            Console.WriteLine("The average is {0}" , avg);
            Console.ReadKey();
        }
    }
}
