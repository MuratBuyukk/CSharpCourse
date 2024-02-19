using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Add();

            //Console.WriteLine(Add2(2, 3));
            //Console.WriteLine(Add2(2));
            int number1 = 10;
            int number2 = 20;
            int result = Add3(ref number1, number2);
            Console.WriteLine(result);
            Console.WriteLine(number1);

            int number3;
            int result2 = Add4(out number3, number2);
            Console.WriteLine(result);
            Console.WriteLine(number3);
            Console.WriteLine(multiply(number1,number2));
            Console.WriteLine(multiply(number1,number2,number3));
            Console.WriteLine(Add5(1,2,3,4,5,6));
            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Added!!");
        }

        static int Add2(int n1, int n2 = 20)
        {
            return n1 + n2;
        }

        static int Add3(ref int n1, int n2)
        {
            n1 = 30;
            return n1 + n2;
        }

        static int Add4(out int n1, int n2)
        {
            n1 = 20;
            return n1 + n2;
        }

        static int multiply(int n1, int n2)
        {
            return n1*n2;
        }

        static int multiply(int n1, int n2,int n3)
        {
            return n1 * n2 * n3;
        }

        static int Add5(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
