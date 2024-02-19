using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    internal class Program
    {
        static void Main(string[] brargs)
        {
            var number = 150;
            if (number == 10) 
            { 
                Console.WriteLine("number is 10"); 
            } 
            else if (number == 20)
            {
                Console.WriteLine("number is 20");
            }
            else 
            { 
                Console.WriteLine("number is not 10 or 20"); 
            }
            Console.WriteLine(number == 10 ? "Number is 10" : number == 20 ? "Number is 20" : "Number is not 10 or 20");


            switch (number)
            {
                case 10: Console.WriteLine("NuMber is 10");
                    break; 
                case 20: Console.WriteLine("NuMber is 20");
                    break;
                default: Console.WriteLine("NuMber is not 10 or 20");
                    break;
            }

            if (number >=0 && number <= 100) { Console.WriteLine("Number Between 0-100"); }
            else if (number > 100 && number <= 200) { Console.WriteLine("Number Between 101-200"); }
            else if (number > 200 || number < 0) { Console.WriteLine("Number is not Between 0-200"); }
            Console.ReadLine();
        }
    }
}
