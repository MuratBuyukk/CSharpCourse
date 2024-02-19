using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 1234567891;
            long number2 = 1234567891234567891;
            short number3 = 12345;
            byte number4 = 0;
            byte number5 = 255;
            bool condition = false;
            char character = 'A';
            double number6 = 10.1234567890123;
            decimal number7 = 10.123456789012345678901234567m;
            var number8 = 10;
            number8 = 'A';
            Console.WriteLine("Number is {0} and {1} and {2}", number1, number2, number3);
            Console.WriteLine("Byte can take value form {0} to {1}", number4, number5);
            Console.WriteLine("Character is: {0}", (int)character);
            Console.WriteLine("Double is: {0}", number6);
            Console.WriteLine("Decimal is: {0}", number7);
            Console.WriteLine((int)Days.Friday);
            Console.WriteLine("Var value is: {0}", number8);
            Console.ReadLine();
        }
    }

    enum Days
    {
        Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday
    }
}
