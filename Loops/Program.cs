using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ForLoop();
            // WhileLoop();
            // DoWhile();
            //ForEach();

            if (IsPrimeNumber(8))
            {
                Console.WriteLine("This is a Prime number");
            }
            else
            {
                Console.WriteLine("This is not a Prime number");
            }
            Console.ReadLine();
        }

        private static bool IsPrimeNumber(int number)
        {
            for (int i = 2; i<number/2; i++)
            {
                if (number%i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        private static void ForEach()
        {
            string[] students =
                        {
                "Murat", "Aleyna", "Hatice"
            };

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }

        private static void DoWhile()
        {
            int number = 10;
            do
            {
                Console.WriteLine(number);
                number--;
            } while (number > 11);
        }

        private static void WhileLoop()
        {
            int number = 100;
            while (number >= 0)
            {
                Console.WriteLine(number);
                number--;
            }
            Console.WriteLine("Now number is {0}", number);
        }

        private static void ForLoop()
        {
            for (int i = 100; i >= 0; i -= 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("finished");
        }
    }
}
