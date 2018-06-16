using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _61618
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numGen = new Random();
            int[,] nums = new int[100, 100];
            for(int i = 0; i < nums.GetLength(0); i++)
            {

                for(int j = 0; j < nums.GetLength(1); j++)
                {

                    nums[i, j] = numGen.Next(0, 9);

                }

            }
            for(int i = 0; i < nums.GetLength(0); i++)
            {
                for (int j = 0; j < nums.GetLength(1); j++)
                {
                    Console.Write($"{nums[i, j]} ");
                }

                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
