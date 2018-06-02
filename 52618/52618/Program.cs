using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _52618
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             1111 = 15 
              
              
             */

            Console.WriteLine("Hello User, please enter a binary sequence and I'll convert it to decimal. ");
            string binary = Console.ReadLine();
            int decimalReturned = 0;
  


                int tmp = (int)Math.Pow(2, binary.Length);
                for (int i = 0; i < binary.Length; i++)
                {

                    if(binary[i] == '1')
                    {
                        decimalReturned += tmp;
                        
                    }
                    tmp /= 2;
                }
                Console.WriteLine($"You put in {binary} and got {decimalReturned / 2}. Congrats!");



            
            Console.ReadKey();

        }
    }
}
