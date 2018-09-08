using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9818
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a 5x5 int array
            // fill it up with random numbers ranging from 0 to 100
            // print out the values of both diagonals and the sum of each diagonal
            Console.WriteLine("I will make a 2-D Array and give you the diagonals.");
            int[,] array2D = new int[5,5];
            Random gen = new Random();
            int numRows = array2D.GetLength(0);
            int diag0 = 0;
            int diag1 = 0;
            for(int i = 0; i < array2D.GetLength(0); i++)
            {
                for(int j = 0; j < array2D.GetLength(1); j++)
                {
                    array2D[i, j] = gen.Next(0, 100);
                }
            }
            Console.WriteLine("All of the numbers are");
            for(int i = 0; i < array2D.GetLength(0); i++)
            {
                for(int j = 0; j < array2D.GetLength(1); j++)
                {
                    Console.Write($"{array2D[i,j]}  ");
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine("Here are the numbers from the top left to the bottom right.");
            for(int i = 0; i < array2D.GetLength(0); i++)
            {
                Console.WriteLine($"{array2D[i, i]}");
                diag0 += array2D[i, i];
            }
            Console.WriteLine("Now, here are the numbers from the top right to the bottom left.");
            for(int i = 0; i < array2D.GetLength(0); i++)
            {
                Console.WriteLine($"{array2D[i,4-i]}");
                diag1 += array2D[i, 4 - i];
            }
            Console.WriteLine($"Oh yeah. The sum of the numbers in the first diagonal is {diag0} and the second one is {diag1}");

            Console.ReadKey();


        }
    }
}
