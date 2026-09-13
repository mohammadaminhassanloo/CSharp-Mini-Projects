using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Fizz_Buzz_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the last number of range: ");
            int givenNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            for (int i = 1; i <= givenNumber; i++)
            {
                if (i % 15 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }

            }
            Console.ReadKey();
        }
    }
}
