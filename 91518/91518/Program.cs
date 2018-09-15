using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _91518
{
    class Program
    {
        static void Main(string[] args)
        {
            //3-D ARRAYS!
            int largestTotal = 0;
            int largestTable = 0;
            int[,,] tables = new int[8, 5, 5];
            Random gen = new Random();
            int[] tableValues = new int[tables.GetLength(0)];

            for(int i = 0; i < tables.GetLength(0); i++)
            {
                for(int j = 0; j < tables.GetLength(1); j++)
                {
                    for(int k = 0; k < tables.GetLength(2); k++)
                    {
                        tables[i, j, k] = gen.Next(0, 5);
                    }
                }
            }
            for(int i = 0; i < tables.GetLength(0); i++)
            {

                for(int j = 0; j < tables.GetLength(1); j++)
                {
                    for(int k = 0; k < tables.GetLength(2); k++)
                    {
                        tableValues[i] += tables[i, j, k];
                    }
                }
            }
            largestTotal = tableValues[0];
            for(int i = 0; i < tables.GetLength(0); i++)
            {
                if(tableValues[i] > largestTotal)
                {
                    largestTotal = tableValues[i];
                }
            }
            Console.WriteLine("Hello User, I have made a  T  H  R  E  E  D  A  R  R  A  Y  . I filled it with random  N  U  M  B  E  R  S  . I will print each TABLE and tell which one is B  I  G  G  E  R  . ");
            for(int i = 0; i < tables.GetLength(0); i++)
            {
                Console.WriteLine($"Table {i + 1} is");
                for(int j = 0; j < tables.GetLength(1); j++)
                {
                    for(int k = 0; k < tables.GetLength(2); k++)
                    {
                        Console.Write($"{tables[i, j, k]}  ");
                    }
                    Console.WriteLine(" ");
                }
                Console.WriteLine($"It's total is {tableValues[i]}. ");
            }
            for(int i = 0; i < tables.GetLength(0); i++)
            {
                if(largestTotal == tableValues[i])
                {
                    largestTable = i + 1;
                }
            }
            Console.WriteLine($"The table with the highest value of numbers is {largestTable}. It's value is {tableValues[largestTable - 1]}");
            Console.ReadKey();
        }
    }
}
