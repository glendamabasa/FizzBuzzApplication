using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Looping through numbers from 1 - 100
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz"); //Writing FizzBuzz to the console
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz"); //Writing Fizz to the console
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine($"Buzz {i}");//Writing Buzz and number at index i to the console
                }
                else
                {
                    Console.WriteLine(i); //Writing number at index i to the console
                }
            }
            Console.ReadLine();
        }
    }
}
