using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _102718
{
    class Program
    {
        static bool isPrime(int number)
        {

            if (number < 2)
            {
                return false;
            }
            else if (number == 2)
            {
                return true;
            }
            else if (number % 2 == 0)
            {
                return false;
            }
            else
            {
                for (int i = 3; i <= Math.Sqrt(number); i += 2)
                {
                    if (number % i == 0)
                    {
                        return false;
                    }


                }

                return true;

            }

        }

        static void Main(string[] args)
        {
            int countUp = 0;
            int numberOfPrimes = 0;
            // print out all the prime numbers from 0 to 100
            // create a function called isPrime which takes a number and returns a true if its a prime, false otherwise
            // 2 is the first prime number, prime numbers besides 2 are all odd, and a prime number is a number divisible by only 1 and itself
            while (numberOfPrimes < 2148000000)
            {
                if (isPrime(countUp))
                {
                    numberOfPrimes++;
                    Console.WriteLine(countUp);
                }
                countUp++;
            }
            Console.WriteLine("There are a LOT of prime numbers!");
            Console.ReadKey();
        }
    }
}
