using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _101318
{
    class Program
    {
        static void Main(string[] args)
        {

            //Create a 2D array of dimensions 5x5, display it on screen
            int[,] array = new int[5, 5];
            Random random = new Random();
            for(int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    array[i, j] = random.Next(10, 99);
                }
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"{array[i, j]}, ");
                }
                Console.WriteLine("");
            }
            //ask the user to type "column" or "row"
            char select = '0';
            Console.WriteLine("Hello User, Please type C for Column or R for Row.");
            while(select != 'C' && select != 'R')
            {
                select = Console.ReadLine()[0];
                
                if (select != 'C' && select != 'R')
                {
                    Console.WriteLine("Try again. Please enter C for Column or R for Row.");
                }
            }

            //ask the user for a number
            int one2five = 6;
            Console.WriteLine("Give me a number between 1 and 5");
            while (one2five > 5)
            {
                one2five = int.Parse(Console.ReadLine()) - 1;
                if(one2five > 5)
                {
                    Console.WriteLine("Sorry, that number is too big. Please try again.");
                }
            }

            //display the largest item in that column or row
            int largest = 0;
            if (select == 'C')
            {
                for (int i = 0; i < 5; i++)
                {
                   if( array[i,one2five] > largest)
                    {
                        largest = array[i,one2five];
                    }
                }

            }
            else
            {
                for (int i = 0; i < 5; i++)
                {
                    if (array[one2five,i] > largest)
                    {
                        largest = array[one2five,i];
                    }
                }
            }
            Console.WriteLine($"The largest number in your column or row is {largest}.");
            Console.ReadKey();

        }
    }
}
