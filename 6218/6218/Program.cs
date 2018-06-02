using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6218
{
    class Program
    {
        static void Main(string[] args)
        {
            // sum the digits of a string of #s the user entered  and display it on the screen
            // ex. 12345 = 15
            Console.WriteLine("Hello User, give me a string of numbers and i will figure out the sum of the numbers.");
            string sNumbers = Console.ReadLine();
            
            int[] numbers = new int[sNumbers.Length];
            for (int i = 0; i < sNumbers.Length; i++)
            {
                numbers[i] = int.Parse(sNumbers[i].ToString());
            }
            int sum = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine($"The sum of your numbers is {sum}.");
            Console.ReadKey();
        }
    }
}
